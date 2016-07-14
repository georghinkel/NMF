//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The default implementation of the TypedElement class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//TypedElement/")]
    [DebuggerDisplayAttribute("TypedElement {Name}")]
    public abstract class TypedElement : MetaElement, ITypedElement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the IsOrdered property
        /// </summary>
        private bool _isOrdered;
        
        /// <summary>
        /// The backing field for the IsUnique property
        /// </summary>
        private bool _isUnique;
        
        /// <summary>
        /// The backing field for the LowerBound property
        /// </summary>
        private int _lowerBound = 0;
        
        /// <summary>
        /// The backing field for the UpperBound property
        /// </summary>
        private int _upperBound = 1;
        
        /// <summary>
        /// The backing field for the Type property
        /// </summary>
        private IType _type;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The IsOrdered property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual bool IsOrdered
        {
            get
            {
                return this._isOrdered;
            }
            set
            {
                if ((this._isOrdered != value))
                {
                    this.OnIsOrderedChanging(EventArgs.Empty);
                    this.OnPropertyChanging("IsOrdered");
                    bool old = this._isOrdered;
                    this._isOrdered = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIsOrderedChanged(e);
                    this.OnPropertyChanged("IsOrdered", e);
                }
            }
        }
        
        /// <summary>
        /// The IsUnique property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual bool IsUnique
        {
            get
            {
                return this._isUnique;
            }
            set
            {
                if ((this._isUnique != value))
                {
                    this.OnIsUniqueChanging(EventArgs.Empty);
                    this.OnPropertyChanging("IsUnique");
                    bool old = this._isUnique;
                    this._isUnique = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIsUniqueChanged(e);
                    this.OnPropertyChanged("IsUnique", e);
                }
            }
        }
        
        /// <summary>
        /// The LowerBound property
        /// </summary>
        [DefaultValueAttribute(0)]
        [XmlAttributeAttribute(true)]
        public virtual int LowerBound
        {
            get
            {
                return this._lowerBound;
            }
            set
            {
                if ((this._lowerBound != value))
                {
                    this.OnLowerBoundChanging(EventArgs.Empty);
                    this.OnPropertyChanging("LowerBound");
                    int old = this._lowerBound;
                    this._lowerBound = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLowerBoundChanged(e);
                    this.OnPropertyChanged("LowerBound", e);
                }
            }
        }
        
        /// <summary>
        /// The UpperBound property
        /// </summary>
        [DefaultValueAttribute(1)]
        [XmlAttributeAttribute(true)]
        public virtual int UpperBound
        {
            get
            {
                return this._upperBound;
            }
            set
            {
                if ((this._upperBound != value))
                {
                    this.OnUpperBoundChanging(EventArgs.Empty);
                    this.OnPropertyChanging("UpperBound");
                    int old = this._upperBound;
                    this._upperBound = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnUpperBoundChanged(e);
                    this.OnPropertyChanged("UpperBound", e);
                }
            }
        }
        
        /// <summary>
        /// The Type property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((this._type != value))
                {
                    this.OnTypeChanging(EventArgs.Empty);
                    this.OnPropertyChanging("Type");
                    IType old = this._type;
                    this._type = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetType;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetType;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeChanged(e);
                    this.OnPropertyChanged("Type", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TypedElementReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//TypedElement/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the IsOrdered property changes its value
        /// </summary>
        public event EventHandler IsOrderedChanging;
        
        /// <summary>
        /// Gets fired when the IsOrdered property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> IsOrderedChanged;
        
        /// <summary>
        /// Gets fired before the IsUnique property changes its value
        /// </summary>
        public event EventHandler IsUniqueChanging;
        
        /// <summary>
        /// Gets fired when the IsUnique property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> IsUniqueChanged;
        
        /// <summary>
        /// Gets fired before the LowerBound property changes its value
        /// </summary>
        public event EventHandler LowerBoundChanging;
        
        /// <summary>
        /// Gets fired when the LowerBound property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> LowerBoundChanged;
        
        /// <summary>
        /// Gets fired before the UpperBound property changes its value
        /// </summary>
        public event EventHandler UpperBoundChanging;
        
        /// <summary>
        /// Gets fired when the UpperBound property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> UpperBoundChanged;
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        public event EventHandler TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Raises the IsOrderedChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsOrderedChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.IsOrderedChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IsOrderedChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsOrderedChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.IsOrderedChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IsUniqueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsUniqueChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.IsUniqueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IsUniqueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsUniqueChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.IsUniqueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LowerBoundChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLowerBoundChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.LowerBoundChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LowerBoundChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLowerBoundChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.LowerBoundChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the UpperBoundChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUpperBoundChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.UpperBoundChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the UpperBoundChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUpperBoundChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.UpperBoundChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.TypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.TypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Type property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetType(object sender, System.EventArgs eventArgs)
        {
            this.Type = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "ISORDERED"))
            {
                return this.IsOrdered;
            }
            if ((attribute == "ISUNIQUE"))
            {
                return this.IsUnique;
            }
            if ((attribute == "LOWERBOUND"))
            {
                return this.LowerBound;
            }
            if ((attribute == "UPPERBOUND"))
            {
                return this.UpperBound;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TYPE"))
            {
                this.Type = ((IType)(value));
                return;
            }
            if ((feature == "ISORDERED"))
            {
                this.IsOrdered = ((bool)(value));
                return;
            }
            if ((feature == "ISUNIQUE"))
            {
                this.IsUnique = ((bool)(value));
                return;
            }
            if ((feature == "LOWERBOUND"))
            {
                this.LowerBound = ((int)(value));
                return;
            }
            if ((feature == "UPPERBOUND"))
            {
                this.UpperBound = ((int)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "TYPE"))
            {
                return new TypeProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "TYPE"))
            {
                return new TypeProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//TypedElement/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TypedElement class
        /// </summary>
        public class TypedElementReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TypedElement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TypedElementReferencedElementsCollection(TypedElement parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.Type != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Type == null))
                {
                    IType typeCasted = item.As<IType>();
                    if ((typeCasted != null))
                    {
                        this._parent.Type = typeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Type = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Type))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Type != null))
                {
                    array[arrayIndex] = this._parent.Type;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Type == item))
                {
                    this._parent.Type = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Type).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IsOrdered property
        /// </summary>
        private sealed class IsOrderedProxy : ModelPropertyChange<ITypedElement, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsOrderedProxy(ITypedElement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsOrdered;
                }
                set
                {
                    this.ModelElement.IsOrdered = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IsOrderedChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IsOrderedChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IsUnique property
        /// </summary>
        private sealed class IsUniqueProxy : ModelPropertyChange<ITypedElement, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsUniqueProxy(ITypedElement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsUnique;
                }
                set
                {
                    this.ModelElement.IsUnique = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IsUniqueChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IsUniqueChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the LowerBound property
        /// </summary>
        private sealed class LowerBoundProxy : ModelPropertyChange<ITypedElement, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LowerBoundProxy(ITypedElement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.LowerBound;
                }
                set
                {
                    this.ModelElement.LowerBound = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LowerBoundChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LowerBoundChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the UpperBound property
        /// </summary>
        private sealed class UpperBoundProxy : ModelPropertyChange<ITypedElement, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public UpperBoundProxy(ITypedElement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.UpperBound;
                }
                set
                {
                    this.ModelElement.UpperBound = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.UpperBoundChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.UpperBoundChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Type property
        /// </summary>
        private sealed class TypeProxy : ModelPropertyChange<ITypedElement, IType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeProxy(ITypedElement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IType Value
            {
                get
                {
                    return this.ModelElement.Type;
                }
                set
                {
                    this.ModelElement.Type = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TypeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TypeChanged -= handler;
            }
        }
    }
}

