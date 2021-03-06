﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace NMF.Controls.Diagrams
{
    public class NodeGroup : FrameworkElement
    {

        public IList Source
        {
            get { return (IList)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(IList), typeof(NodeGroup), new PropertyMetadata());

        private Collection<EdgeGroup> edgeGroups = new Collection<EdgeGroup>();

        public Collection<EdgeGroup> EdgeGroups { get { return edgeGroups; } }

        public DataTemplate Template { get; set; }
    }
}
