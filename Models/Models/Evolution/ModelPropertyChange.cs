﻿using NMF.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NMF.Models.Evolution
{
    public class ModelPropertyChange : IModelChange
    {
        public string PropertyName { get; private set; }

        public object NewValue { get; private set; }

        public object OldValue { get; private set; }

        public Uri AbsoluteUri { get; private set; }
        
        public ModelPropertyChange(Uri absoluteUri, string propertyName, object newValue, object oldValue)
        {
            if (absoluteUri == null)
                throw new ArgumentNullException(nameof(absoluteUri));
            if (string.IsNullOrEmpty(propertyName))
                throw new ArgumentNullException(nameof(propertyName));

            AbsoluteUri = absoluteUri;
            PropertyName = propertyName;
            NewValue = newValue;
            OldValue = oldValue;
        }

        public void Apply(IModelRepository repository)
        {
            var parent = repository.Resolve(AbsoluteUri);
            parent?.GetType().GetProperty(PropertyName)?.SetValue(parent, NewValue, null);
        }

        public void Undo(IModelRepository repository)
        {
            var parent = repository.Resolve(AbsoluteUri);
            parent?.GetType().GetProperty(PropertyName)?.SetValue(parent, OldValue, null);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;
            var other = obj as ModelPropertyChange;
            if (other == null)
                return false;
            else
                return this.AbsoluteUri.Equals(other.AbsoluteUri)
                    && this.NewValue.Equals(other.NewValue)
                    && this.OldValue.Equals(other.OldValue)
                    && this.PropertyName.Equals(other.PropertyName);
        }
    }
}
