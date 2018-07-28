using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace NMF.Controls.Diagrams
{
    public class EdgeGroup : FrameworkElement
    {
        public IList Source
        {
            get { return (IList)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(IList), typeof(EdgeGroup), new PropertyMetadata());

        public DataTemplate Template { get; set; }
    }
}
