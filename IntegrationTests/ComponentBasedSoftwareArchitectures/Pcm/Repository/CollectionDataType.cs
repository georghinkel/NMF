//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Protocol;
using NMFExamples.Pcm.Reliability;
using NMFExamples.Pcm.Resourcetype;
using NMFExamples.Pcm.Seff;
using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace NMFExamples.Pcm.Repository
{
    
    
    /// <summary>
    /// The default implementation of the CollectionDataType class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/CollectionDataType")]
    [DebuggerDisplayAttribute("CollectionDataType {Id}")]
    public partial class CollectionDataType : NMFExamples.Pcm.Core.Entity.Entity, ICollectionDataType, IModelElement
    {
        
        private static Lazy<ITypedElement> _innerType_CollectionDataTypeReference = new Lazy<ITypedElement>(RetrieveInnerType_CollectionDataTypeReference);
        
        /// <summary>
        /// The backing field for the InnerType_CollectionDataType property
        /// </summary>
        private IDataType _innerType_CollectionDataType;
        
        private static Lazy<ITypedElement> _repository__DataTypeReference = new Lazy<ITypedElement>(RetrieveRepository__DataTypeReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The innerType_CollectionDataType property
        /// </summary>
        [XmlElementNameAttribute("innerType_CollectionDataType")]
        [XmlAttributeAttribute(true)]
        public IDataType InnerType_CollectionDataType
        {
            get
            {
                return this._innerType_CollectionDataType;
            }
            set
            {
                if ((this._innerType_CollectionDataType != value))
                {
                    IDataType old = this._innerType_CollectionDataType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInnerType_CollectionDataTypeChanging(e);
                    this.OnPropertyChanging("InnerType_CollectionDataType", e, _innerType_CollectionDataTypeReference);
                    this._innerType_CollectionDataType = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetInnerType_CollectionDataType;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetInnerType_CollectionDataType;
                    }
                    this.OnInnerType_CollectionDataTypeChanged(e);
                    this.OnPropertyChanged("InnerType_CollectionDataType", e, _innerType_CollectionDataTypeReference);
                }
            }
        }
        
        /// <summary>
        /// The repository__DataType property
        /// </summary>
        [XmlElementNameAttribute("repository__DataType")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("dataTypes__Repository")]
        public IRepository Repository__DataType
        {
            get
            {
                return ModelHelper.CastAs<IRepository>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new CollectionDataTypeChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CollectionDataTypeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/CollectionDataType")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the InnerType_CollectionDataType property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> InnerType_CollectionDataTypeChanging;
        
        /// <summary>
        /// Gets fired when the InnerType_CollectionDataType property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> InnerType_CollectionDataTypeChanged;
        
        /// <summary>
        /// Gets fired before the Repository__DataType property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> Repository__DataTypeChanging;
        
        /// <summary>
        /// Gets fired when the Repository__DataType property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> Repository__DataTypeChanged;
        
        private static ITypedElement RetrieveInnerType_CollectionDataTypeReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.CollectionDataType.ClassInstance)).Resolve("innerType_CollectionDataType")));
        }
        
        /// <summary>
        /// Raises the InnerType_CollectionDataTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInnerType_CollectionDataTypeChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.InnerType_CollectionDataTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the InnerType_CollectionDataTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInnerType_CollectionDataTypeChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.InnerType_CollectionDataTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the InnerType_CollectionDataType property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetInnerType_CollectionDataType(object sender, global::System.EventArgs eventArgs)
        {
            this.InnerType_CollectionDataType = null;
        }
        
        private static ITypedElement RetrieveRepository__DataTypeReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.DataType.ClassInstance)).Resolve("repository__DataType")));
        }
        
        /// <summary>
        /// Raises the Repository__DataTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRepository__DataTypeChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.Repository__DataTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            IRepository oldRepository__DataType = ModelHelper.CastAs<IRepository>(oldParent);
            IRepository newRepository__DataType = ModelHelper.CastAs<IRepository>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRepository__DataType, newRepository__DataType);
            this.OnRepository__DataTypeChanging(e);
            this.OnPropertyChanging("Repository__DataType", e, _repository__DataTypeReference);
        }
        
        /// <summary>
        /// Raises the Repository__DataTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRepository__DataTypeChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.Repository__DataTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            IRepository oldRepository__DataType = ModelHelper.CastAs<IRepository>(oldParent);
            IRepository newRepository__DataType = ModelHelper.CastAs<IRepository>(newParent);
            if ((oldRepository__DataType != null))
            {
                oldRepository__DataType.DataTypes__Repository.Remove(this);
            }
            if ((newRepository__DataType != null))
            {
                newRepository__DataType.DataTypes__Repository.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRepository__DataType, newRepository__DataType);
            this.OnRepository__DataTypeChanged(e);
            this.OnPropertyChanged("Repository__DataType", e, _repository__DataTypeReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "INNERTYPE_COLLECTIONDATATYPE"))
            {
                this.InnerType_CollectionDataType = ((IDataType)(value));
                return;
            }
            if ((feature == "REPOSITORY__DATATYPE"))
            {
                this.Repository__DataType = ((IRepository)(value));
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
            if ((attribute == "InnerType_CollectionDataType"))
            {
                return new InnerType_CollectionDataTypeProxy(this);
            }
            if ((attribute == "Repository__DataType"))
            {
                return new Repository__DataTypeProxy(this);
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
            if ((reference == "InnerType_CollectionDataType"))
            {
                return new InnerType_CollectionDataTypeProxy(this);
            }
            if ((reference == "Repository__DataType"))
            {
                return new Repository__DataTypeProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/CollectionDataType")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CollectionDataType class
        /// </summary>
        public class CollectionDataTypeChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CollectionDataType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CollectionDataTypeChildrenCollection(CollectionDataType parent)
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
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
            }
            
            protected override void DetachCore()
            {
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CollectionDataType class
        /// </summary>
        public class CollectionDataTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CollectionDataType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CollectionDataTypeReferencedElementsCollection(CollectionDataType parent)
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
                    if ((this._parent.InnerType_CollectionDataType != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Repository__DataType != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InnerType_CollectionDataTypeChanged += this.PropagateValueChanges;
                this._parent.Repository__DataTypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InnerType_CollectionDataTypeChanged -= this.PropagateValueChanges;
                this._parent.Repository__DataTypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.InnerType_CollectionDataType == null))
                {
                    IDataType innerType_CollectionDataTypeCasted = item.As<IDataType>();
                    if ((innerType_CollectionDataTypeCasted != null))
                    {
                        this._parent.InnerType_CollectionDataType = innerType_CollectionDataTypeCasted;
                        return;
                    }
                }
                if ((this._parent.Repository__DataType == null))
                {
                    IRepository repository__DataTypeCasted = item.As<IRepository>();
                    if ((repository__DataTypeCasted != null))
                    {
                        this._parent.Repository__DataType = repository__DataTypeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InnerType_CollectionDataType = null;
                this._parent.Repository__DataType = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.InnerType_CollectionDataType))
                {
                    return true;
                }
                if ((item == this._parent.Repository__DataType))
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
                if ((this._parent.InnerType_CollectionDataType != null))
                {
                    array[arrayIndex] = this._parent.InnerType_CollectionDataType;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Repository__DataType != null))
                {
                    array[arrayIndex] = this._parent.Repository__DataType;
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
                if ((this._parent.InnerType_CollectionDataType == item))
                {
                    this._parent.InnerType_CollectionDataType = null;
                    return true;
                }
                if ((this._parent.Repository__DataType == item))
                {
                    this._parent.Repository__DataType = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InnerType_CollectionDataType).Concat(this._parent.Repository__DataType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the innerType_CollectionDataType property
        /// </summary>
        private sealed class InnerType_CollectionDataTypeProxy : ModelPropertyChange<ICollectionDataType, IDataType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InnerType_CollectionDataTypeProxy(ICollectionDataType modelElement) : 
                    base(modelElement, "innerType_CollectionDataType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDataType Value
            {
                get
                {
                    return this.ModelElement.InnerType_CollectionDataType;
                }
                set
                {
                    this.ModelElement.InnerType_CollectionDataType = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the repository__DataType property
        /// </summary>
        private sealed class Repository__DataTypeProxy : ModelPropertyChange<IDataType, IRepository>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Repository__DataTypeProxy(IDataType modelElement) : 
                    base(modelElement, "repository__DataType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRepository Value
            {
                get
                {
                    return this.ModelElement.Repository__DataType;
                }
                set
                {
                    this.ModelElement.Repository__DataType = value;
                }
            }
        }
    }
}
