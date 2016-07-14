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
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Interop.Ecore
{
    
    
    /// <summary>
    /// The public interface for EStringToStringMapEntry
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EStringToStringMapEntry))]
    [XmlDefaultImplementationTypeAttribute(typeof(EStringToStringMapEntry))]
    public interface IEStringToStringMapEntry : IModelElement
    {
        
        /// <summary>
        /// The key property
        /// </summary>
        string Key
        {
            get;
            set;
        }
        
        /// <summary>
        /// The value property
        /// </summary>
        string Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Key property changes its value
        /// </summary>
        event EventHandler KeyChanging;
        
        /// <summary>
        /// Gets fired when the Key property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> KeyChanged;
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        event EventHandler ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ValueChanged;
    }
}

