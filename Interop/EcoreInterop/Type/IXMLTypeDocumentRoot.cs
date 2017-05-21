//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Interop.Ecore;
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Interop.Type
{
    
    
    /// <summary>
    /// The public interface for XMLTypeDocumentRoot
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(XMLTypeDocumentRoot))]
    [XmlDefaultImplementationTypeAttribute(typeof(XMLTypeDocumentRoot))]
    public interface IXMLTypeDocumentRoot : IModelElement
    {
        
        /// <summary>
        /// The mixed property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("mixed")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        IListExpression<object> Mixed
        {
            get;
        }
        
        /// <summary>
        /// The xMLNSPrefixMap property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("xMLNSPrefixMap")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        IOrderedSetExpression<IEStringToStringMapEntry> XMLNSPrefixMap
        {
            get;
        }
        
        /// <summary>
        /// The xSISchemaLocation property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("xSISchemaLocation")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        IOrderedSetExpression<IEStringToStringMapEntry> XSISchemaLocation
        {
            get;
        }
    }
}
