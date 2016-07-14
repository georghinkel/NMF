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
    /// The public interface for Reference
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Reference))]
    [XmlDefaultImplementationTypeAttribute(typeof(Reference))]
    public interface IReference : IModelElement, ITypedElement
    {
        
        /// <summary>
        /// The IsContainment property
        /// </summary>
        bool IsContainment
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DeclaringType property
        /// </summary>
        IReferenceType DeclaringType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Opposite property
        /// </summary>
        IReference Opposite
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ReferenceType property
        /// </summary>
        IReferenceType ReferenceType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The reference that is refined by the current reference, only applicable if the reference is part of a class
        /// </summary>
        IReference Refines
        {
            get;
            set;
        }
        
        /// <summary>
        /// The least common anchestor of an instance and its referenced element, if statically known
        /// </summary>
        IClass Anchor
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the IsContainment property changes its value
        /// </summary>
        event EventHandler IsContainmentChanging;
        
        /// <summary>
        /// Gets fired when the IsContainment property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> IsContainmentChanged;
        
        /// <summary>
        /// Gets fired when the DeclaringType property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> DeclaringTypeChanged;
        
        /// <summary>
        /// Gets fired before the Opposite property changes its value
        /// </summary>
        event EventHandler OppositeChanging;
        
        /// <summary>
        /// Gets fired when the Opposite property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> OppositeChanged;
        
        /// <summary>
        /// Gets fired before the ReferenceType property changes its value
        /// </summary>
        event EventHandler ReferenceTypeChanging;
        
        /// <summary>
        /// Gets fired when the ReferenceType property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ReferenceTypeChanged;
        
        /// <summary>
        /// Gets fired before the Refines property changes its value
        /// </summary>
        event EventHandler RefinesChanging;
        
        /// <summary>
        /// Gets fired when the Refines property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> RefinesChanged;
        
        /// <summary>
        /// Gets fired before the Anchor property changes its value
        /// </summary>
        event EventHandler AnchorChanging;
        
        /// <summary>
        /// Gets fired when the Anchor property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> AnchorChanged;
    }
}

