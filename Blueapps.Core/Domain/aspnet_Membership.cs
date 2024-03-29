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
    public partial class aspnet_Membership
    {
        #region Primitive Properties
    
        public virtual System.Guid ApplicationId
        {
            get { return _applicationId; }
            set
            {
                if (_applicationId != value)
                {
                    if (aspnet_Applications != null && aspnet_Applications.ApplicationId != value)
                    {
                        aspnet_Applications = null;
                    }
                    _applicationId = value;
                }
            }
        }
        private System.Guid _applicationId;
    
        public virtual System.Guid UserId
        {
            get { return _userId; }
            set
            {
                if (_userId != value)
                {
                    if (aspnet_Users != null && aspnet_Users.UserId != value)
                    {
                        aspnet_Users = null;
                    }
                    _userId = value;
                }
            }
        }
        private System.Guid _userId;
    
        public virtual string Password
        {
            get;
            set;
        }
    
        public virtual int PasswordFormat
        {
            get;
            set;
        }
    
        public virtual string PasswordSalt
        {
            get;
            set;
        }
    
        public virtual string MobilePIN
        {
            get;
            set;
        }
    
        public virtual string Email
        {
            get;
            set;
        }
    
        public virtual string LoweredEmail
        {
            get;
            set;
        }
    
        public virtual string PasswordQuestion
        {
            get;
            set;
        }
    
        public virtual string PasswordAnswer
        {
            get;
            set;
        }
    
        public virtual bool IsApproved
        {
            get;
            set;
        }
    
        public virtual bool IsLockedOut
        {
            get;
            set;
        }
    
        public virtual System.DateTime CreateDate
        {
            get;
            set;
        }
    
        public virtual System.DateTime LastLoginDate
        {
            get;
            set;
        }
    
        public virtual System.DateTime LastPasswordChangedDate
        {
            get;
            set;
        }
    
        public virtual System.DateTime LastLockoutDate
        {
            get;
            set;
        }
    
        public virtual int FailedPasswordAttemptCount
        {
            get;
            set;
        }
    
        public virtual System.DateTime FailedPasswordAttemptWindowStart
        {
            get;
            set;
        }
    
        public virtual int FailedPasswordAnswerAttemptCount
        {
            get;
            set;
        }
    
        public virtual System.DateTime FailedPasswordAnswerAttemptWindowStart
        {
            get;
            set;
        }
    
        public virtual string Comment
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual aspnet_Applications aspnet_Applications
        {
            get { return _aspnet_Applications; }
            set
            {
                if (!ReferenceEquals(_aspnet_Applications, value))
                {
                    var previousValue = _aspnet_Applications;
                    _aspnet_Applications = value;
                    Fixupaspnet_Applications(previousValue);
                }
            }
        }
        private aspnet_Applications _aspnet_Applications;
    
        public virtual aspnet_Users aspnet_Users
        {
            get { return _aspnet_Users; }
            set
            {
                if (!ReferenceEquals(_aspnet_Users, value))
                {
                    var previousValue = _aspnet_Users;
                    _aspnet_Users = value;
                    Fixupaspnet_Users(previousValue);
                }
            }
        }
        private aspnet_Users _aspnet_Users;

        #endregion
        #region Association Fixup
    
        private void Fixupaspnet_Applications(aspnet_Applications previousValue)
        {
            if (previousValue != null && previousValue.aspnet_Membership.Contains(this))
            {
                previousValue.aspnet_Membership.Remove(this);
            }
    
            if (aspnet_Applications != null)
            {
                if (!aspnet_Applications.aspnet_Membership.Contains(this))
                {
                    aspnet_Applications.aspnet_Membership.Add(this);
                }
                if (ApplicationId != aspnet_Applications.ApplicationId)
                {
                    ApplicationId = aspnet_Applications.ApplicationId;
                }
            }
        }
    
        private void Fixupaspnet_Users(aspnet_Users previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.aspnet_Membership, this))
            {
                previousValue.aspnet_Membership = null;
            }
    
            if (aspnet_Users != null)
            {
                aspnet_Users.aspnet_Membership = this;
                if (UserId != aspnet_Users.UserId)
                {
                    UserId = aspnet_Users.UserId;
                }
            }
        }

        #endregion
    }
}
