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
using NMF.Models.Meta;
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

namespace NMF.Expressions.IncrementalizationConfiguration
{
    
    
    /// <summary>
    /// The default implementation of the MethodConfiguration class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/incrementalizationConfig")]
    [XmlNamespacePrefixAttribute("conf")]
    [DebuggerDisplay("{MethodIdentifier}")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/incrementalizationConfig#//MethodConfiguration/")]
    public class MethodConfiguration : ModelElement, IMethodConfiguration, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MethodIdentifier property
        /// </summary>
        private string _methodIdentifier;
        
        /// <summary>
        /// The backing field for the Strategy property
        /// </summary>
        private IncrementalizationStrategy _strategy;
        
        /// <summary>
        /// The backing field for the AllowedStrategies property
        /// </summary>
        private ObservableList<IncrementalizationStrategy> _allowedStrategies;
        
        private static IClass _classInstance;
        
        public MethodConfiguration()
        {
            this._allowedStrategies = new ObservableList<IncrementalizationStrategy>();
            this._allowedStrategies.CollectionChanging += this.AllowedStrategiesCollectionChanging;
            this._allowedStrategies.CollectionChanged += this.AllowedStrategiesCollectionChanged;
        }
        
        /// <summary>
        /// The methodIdentifier property
        /// </summary>
        [XmlElementNameAttribute("methodIdentifier")]
        [XmlAttributeAttribute(true)]
        public virtual string MethodIdentifier
        {
            get
            {
                return this._methodIdentifier;
            }
            set
            {
                if ((this._methodIdentifier != value))
                {
                    string old = this._methodIdentifier;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMethodIdentifierChanging(e);
                    this.OnPropertyChanging("MethodIdentifier", e);
                    this._methodIdentifier = value;
                    this.OnMethodIdentifierChanged(e);
                    this.OnPropertyChanged("MethodIdentifier", e);
                }
            }
        }
        
        /// <summary>
        /// The strategy property
        /// </summary>
        [XmlElementNameAttribute("strategy")]
        [XmlAttributeAttribute(true)]
        public virtual IncrementalizationStrategy Strategy
        {
            get
            {
                return this._strategy;
            }
            set
            {
                if ((this._strategy != value))
                {
                    IncrementalizationStrategy old = this._strategy;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStrategyChanging(e);
                    this.OnPropertyChanging("Strategy", e);
                    this._strategy = value;
                    this.OnStrategyChanged(e);
                    this.OnPropertyChanged("Strategy", e);
                }
            }
        }
        
        /// <summary>
        /// The allowedStrategies property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("allowedStrategies")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IListExpression<IncrementalizationStrategy> AllowedStrategies
        {
            get
            {
                return this._allowedStrategies;
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/incrementalizationConfig#//MethodConfiguration/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MethodIdentifier property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MethodIdentifierChanging;
        
        /// <summary>
        /// Gets fired when the MethodIdentifier property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MethodIdentifierChanged;
        
        /// <summary>
        /// Gets fired before the Strategy property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StrategyChanging;
        
        /// <summary>
        /// Gets fired when the Strategy property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StrategyChanged;
        
        /// <summary>
        /// Raises the MethodIdentifierChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMethodIdentifierChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MethodIdentifierChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MethodIdentifierChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMethodIdentifierChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MethodIdentifierChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StrategyChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStrategyChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StrategyChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StrategyChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStrategyChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StrategyChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AllowedStrategies property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AllowedStrategiesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("AllowedStrategies", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AllowedStrategies property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AllowedStrategiesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AllowedStrategies", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "METHODIDENTIFIER"))
            {
                return this.MethodIdentifier;
            }
            if ((attribute == "STRATEGY"))
            {
                return this.Strategy;
            }
            if ((attribute == "ALLOWEDSTRATEGIES"))
            {
                if ((index < this.AllowedStrategies.Count))
                {
                    return this.AllowedStrategies[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ALLOWEDSTRATEGIES"))
            {
                return this._allowedStrategies;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "METHODIDENTIFIER"))
            {
                this.MethodIdentifier = ((string)(value));
                return;
            }
            if ((feature == "STRATEGY"))
            {
                this.Strategy = ((IncrementalizationStrategy)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/incrementalizationConfig#//MethodConfiguration/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the methodIdentifier property
        /// </summary>
        private sealed class MethodIdentifierProxy : ModelPropertyChange<IMethodConfiguration, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MethodIdentifierProxy(IMethodConfiguration modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.MethodIdentifier;
                }
                set
                {
                    this.ModelElement.MethodIdentifier = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MethodIdentifierChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.MethodIdentifierChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the strategy property
        /// </summary>
        private sealed class StrategyProxy : ModelPropertyChange<IMethodConfiguration, IncrementalizationStrategy>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StrategyProxy(IMethodConfiguration modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IncrementalizationStrategy Value
            {
                get
                {
                    return this.ModelElement.Strategy;
                }
                set
                {
                    this.ModelElement.Strategy = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StrategyChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StrategyChanged -= handler;
            }
        }
    }
}

