//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blueapps.Core.Domain
{
    [MetadataType(typeof(Metadata))]
    public partial class aspnet_SchemaVersions
    {
        #region Metadata
    
    	/// <summary>
    	/// Metadata internal class used for Data Annotations
    	/// </summary>
    	internal class Metadata
        {
            #region Primitive Properties
            
            [Display(Name = "Feature")]
            [Required(ErrorMessage = "Feature is Required.")]
            [StringLength(128, ErrorMessage = "Feature must be under 128 characters.")]	
            public virtual string Feature { get; set; }	
            
            [Display(Name = "Compatible Schema Version")]
            [Required(ErrorMessage = "Compatible Schema Version is Required.")]
            [StringLength(128, ErrorMessage = "Compatible Schema Version must be under 128 characters.")]	
            public virtual string CompatibleSchemaVersion { get; set; }	
            
            [Display(Name = "Is Current Version")]
            [Required(ErrorMessage = "Is Current Version is Required.")]	
            public virtual bool IsCurrentVersion { get; set; }	

            #endregion
    
    
    	}

        #endregion
    }
}
