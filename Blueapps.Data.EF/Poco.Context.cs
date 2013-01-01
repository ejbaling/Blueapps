//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{
    public partial class Entities : ObjectContext
    {
        public const string ConnectionString = "name=Entities";
        public const string ContainerName = "Entities";
    
        #region Constructors
    
        public Entities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public Entities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public Entities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<aspnet_Applications> aspnet_Applications
        {
            get { return _aspnet_Applications  ?? (_aspnet_Applications = CreateObjectSet<aspnet_Applications>("aspnet_Applications")); }
        }
        private ObjectSet<aspnet_Applications> _aspnet_Applications;
    
        public ObjectSet<aspnet_Membership> aspnet_Membership
        {
            get { return _aspnet_Membership  ?? (_aspnet_Membership = CreateObjectSet<aspnet_Membership>("aspnet_Membership")); }
        }
        private ObjectSet<aspnet_Membership> _aspnet_Membership;
    
        public ObjectSet<aspnet_Paths> aspnet_Paths
        {
            get { return _aspnet_Paths  ?? (_aspnet_Paths = CreateObjectSet<aspnet_Paths>("aspnet_Paths")); }
        }
        private ObjectSet<aspnet_Paths> _aspnet_Paths;
    
        public ObjectSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers
        {
            get { return _aspnet_PersonalizationAllUsers  ?? (_aspnet_PersonalizationAllUsers = CreateObjectSet<aspnet_PersonalizationAllUsers>("aspnet_PersonalizationAllUsers")); }
        }
        private ObjectSet<aspnet_PersonalizationAllUsers> _aspnet_PersonalizationAllUsers;
    
        public ObjectSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser
        {
            get { return _aspnet_PersonalizationPerUser  ?? (_aspnet_PersonalizationPerUser = CreateObjectSet<aspnet_PersonalizationPerUser>("aspnet_PersonalizationPerUser")); }
        }
        private ObjectSet<aspnet_PersonalizationPerUser> _aspnet_PersonalizationPerUser;
    
        public ObjectSet<aspnet_Profile> aspnet_Profile
        {
            get { return _aspnet_Profile  ?? (_aspnet_Profile = CreateObjectSet<aspnet_Profile>("aspnet_Profile")); }
        }
        private ObjectSet<aspnet_Profile> _aspnet_Profile;
    
        public ObjectSet<aspnet_Roles> aspnet_Roles
        {
            get { return _aspnet_Roles  ?? (_aspnet_Roles = CreateObjectSet<aspnet_Roles>("aspnet_Roles")); }
        }
        private ObjectSet<aspnet_Roles> _aspnet_Roles;
    
        public ObjectSet<aspnet_SchemaVersions> aspnet_SchemaVersions
        {
            get { return _aspnet_SchemaVersions  ?? (_aspnet_SchemaVersions = CreateObjectSet<aspnet_SchemaVersions>("aspnet_SchemaVersions")); }
        }
        private ObjectSet<aspnet_SchemaVersions> _aspnet_SchemaVersions;
    
        public ObjectSet<aspnet_Users> aspnet_Users
        {
            get { return _aspnet_Users  ?? (_aspnet_Users = CreateObjectSet<aspnet_Users>("aspnet_Users")); }
        }
        private ObjectSet<aspnet_Users> _aspnet_Users;
    
        public ObjectSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events
        {
            get { return _aspnet_WebEvent_Events  ?? (_aspnet_WebEvent_Events = CreateObjectSet<aspnet_WebEvent_Events>("aspnet_WebEvent_Events")); }
        }
        private ObjectSet<aspnet_WebEvent_Events> _aspnet_WebEvent_Events;
    
        public ObjectSet<Device> Devices
        {
            get { return _devices  ?? (_devices = CreateObjectSet<Device>("Devices")); }
        }
        private ObjectSet<Device> _devices;

        #endregion
    }
}
