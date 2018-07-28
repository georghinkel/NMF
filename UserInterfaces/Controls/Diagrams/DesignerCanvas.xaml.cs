﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Xml;
using System.Collections.ObjectModel;
using System.Collections;

namespace NMF.Controls.Diagrams
{
    public partial class DesignerCanvas : Canvas
    {
        private Point? rubberbandSelectionStartPoint = null;
        private Collection<NodeGroup> nodeGroups = new Collection<NodeGroup>();

        public Collection<NodeGroup> NodeGroups { get { return nodeGroups; } }

        private SelectionService selectionService;
        internal SelectionService SelectionService
        {
            get
            {
                if (selectionService == null)
                    selectionService = new SelectionService(this);

                return selectionService;
            }
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Source == this)
            {
                // in case that this click is the start of a 
                // drag operation we cache the start point
                this.rubberbandSelectionStartPoint = new Point?(e.GetPosition(this));

                // if you click directly on the canvas all 
                // selected items are 'de-selected'
                SelectionService.ClearSelection();
                Focus();
                e.Handled = true;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // if mouse button is not pressed we have no drag operation, ...
            if (e.LeftButton != MouseButtonState.Pressed)
                this.rubberbandSelectionStartPoint = null;

            // ... but if mouse button is pressed and start
            // point value is set we do have one
            if (this.rubberbandSelectionStartPoint.HasValue)
            {
                // create rubberband adorner
                AdornerLayer adornerLayer = AdornerLayer.GetAdornerLayer(this);
                if (adornerLayer != null)
                {
                    RubberbandAdorner adorner = new RubberbandAdorner(this, rubberbandSelectionStartPoint);
                    if (adorner != null)
                    {
                        adornerLayer.Add(adorner);
                    }
                }
            }
            e.Handled = true;
        }

        protected override void OnDrop(DragEventArgs e)
        {
            base.OnDrop(e);
            DragObject dragObject = e.Data.GetData(typeof(DragObject)) as DragObject;
            if (dragObject != null && !String.IsNullOrEmpty(dragObject.Xaml))
            {
                Object content = XamlReader.Load(XmlReader.Create(new StringReader(dragObject.Xaml)));

                if (content != null)
                {
                    CreateNode(content, null, e.GetPosition(this), dragObject.DesiredSize);
                }

                e.Handled = true;
            }
        }

        private DesignerItem CreateNode(object content, DataTemplate contentTemplate, Point position, Size? desiredSize)
        {
            DesignerItem newItem = new DesignerItem();
            newItem.ContentTemplate = contentTemplate;
            newItem.Content = content;

            if (desiredSize.HasValue)
            {
                newItem.Width = desiredSize.Value.Width;
                newItem.Height = desiredSize.Value.Height;

                DesignerCanvas.SetLeft(newItem, Math.Max(0, position.X - newItem.Width / 2));
                DesignerCanvas.SetTop(newItem, Math.Max(0, position.Y - newItem.Height / 2));
            }
            else
            {
                newItem.Width = 100;
                newItem.Height = 50;

                DesignerCanvas.SetLeft(newItem, Math.Max(0, position.X));
                DesignerCanvas.SetTop(newItem, Math.Max(0, position.Y));
            }

            Canvas.SetZIndex(newItem, this.Children.Count);
            this.Children.Add(newItem);
            SetConnectorDecoratorTemplate(newItem);

            //update selection
            //this.SelectionService.SelectItem(newItem);
            //newItem.Focus();
            return newItem;
        }

        protected override Size MeasureOverride(Size constraint)
        {
            Size size = new Size();

            foreach (UIElement element in this.InternalChildren)
            {
                double left = Canvas.GetLeft(element);
                double top = Canvas.GetTop(element);
                left = double.IsNaN(left) ? 0 : left;
                top = double.IsNaN(top) ? 0 : top;

                //measure desired size for each child
                element.Measure(constraint);

                Size desiredSize = element.DesiredSize;
                if (!double.IsNaN(desiredSize.Width) && !double.IsNaN(desiredSize.Height))
                {
                    size.Width = Math.Max(size.Width, left + desiredSize.Width);
                    size.Height = Math.Max(size.Height, top + desiredSize.Height);
                }
            }
            // add margin 
            size.Width += 10;
            size.Height += 10;
            return size;
        }

        private void SetConnectorDecoratorTemplate(DesignerItem item)
        {
            if (item.ApplyTemplate() && item.Content is UIElement)
            {
                ControlTemplate template = DesignerItem.GetConnectorDecoratorTemplate(item.Content as UIElement);
                Control decorator = item.Template.FindName("PART_ConnectorDecorator", item) as Control;
                if (decorator != null && template != null)
                    decorator.Template = template;
            }
        }

        public void LoadRoot(object root)
        {
            this.Children.Clear();
            this.SelectionService.ClearSelection();
            foreach (var group in NodeGroups)
            {
                group.DataContext = root;
                if (group.Source != null && group.Source.Count > 0)
                {
                    var ratio = ActualWidth * ActualHeight == 0 ? 1 : ActualHeight / ActualWidth;
                    var elementsPerRow = (int)Math.Ceiling(Math.Sqrt(group.Source.Count / ratio));
                    var elementsRows = group.Source.Count / elementsPerRow;
                    var row = 0;
                    var column = 0;
                    foreach (var node in group.Source)
                    {
                        var pos = new Point(row * ActualWidth / elementsPerRow, column * ActualHeight / elementsRows);
                        var item = CreateNode(node, group.Template, pos, null);
                        column++;
                        if (column == elementsPerRow)
                        {
                            row++;
                            column = 0;
                        }
                    }
                }
            }
        }


        internal void CreateConnection(Connector sourceConnector, Connector sinkConnector)
        {
            Connection newConnection = new Connection(sourceConnector, sinkConnector);
            newConnection.Label = "42";

            Canvas.SetZIndex(newConnection, Children.Count);
            Children.Add(newConnection);
        }
    }
}