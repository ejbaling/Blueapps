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

namespace Blueapps.Core.Domain
{
    [Serializable()]
    public partial class aspnet_WebEvent_Events
    {
        #region Primitive Properties
    
        public virtual string EventId
        {
            get;
            set;
        }
    
        public virtual System.DateTime EventTimeUtc
        {
            get;
            set;
        }
    
        public virtual System.DateTime EventTime
        {
            get;
            set;
        }
    
        public virtual string EventType
        {
            get;
            set;
        }
    
        public virtual decimal EventSequence
        {
            get;
            set;
        }
    
        public virtual decimal EventOccurrence
        {
            get;
            set;
        }
    
        public virtual int EventCode
        {
            get;
            set;
        }
    
        public virtual int EventDetailCode
        {
            get;
            set;
        }
    
        public virtual string Message
        {
            get;
            set;
        }
    
        public virtual string ApplicationPath
        {
            get;
            set;
        }
    
        public virtual string ApplicationVirtualPath
        {
            get;
            set;
        }
    
        public virtual string MachineName
        {
            get;
            set;
        }
    
        public virtual string RequestUrl
        {
            get;
            set;
        }
    
        public virtual string ExceptionType
        {
            get;
            set;
        }
    
        public virtual string Details
        {
            get;
            set;
        }

        #endregion
    }
}
