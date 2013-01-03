using StructureMap.Configuration.DSL;
using Blueapps.Core.Repository;
using System.Data.Objects;

namespace Blueapps.Data.EF
{
    public class EFRepositoryRegistry : Registry
    {
        public EFRepositoryRegistry()
        {
            // Repositories - StructureMap DI Registration
            For(typeof(IRepository<>)).Use(typeof(EFRepository<>));
            For(typeof(IReadOnlyRepository<>)).Use(typeof(EFReadOnlyRepository<>));
            For<Iaspnet_ApplicationsRepository>().Use<aspnet_ApplicationsEFRepository>();
            For<Iaspnet_MembershipRepository>().Use<aspnet_MembershipEFRepository>();
            For<Iaspnet_PathsRepository>().Use<aspnet_PathsEFRepository>();
            For<Iaspnet_PersonalizationAllUsersRepository>().Use<aspnet_PersonalizationAllUsersEFRepository>();
            For<Iaspnet_PersonalizationPerUserRepository>().Use<aspnet_PersonalizationPerUserEFRepository>();
            For<Iaspnet_ProfileRepository>().Use<aspnet_ProfileEFRepository>();
            For<Iaspnet_RolesRepository>().Use<aspnet_RolesEFRepository>();
            For<Iaspnet_SchemaVersionsRepository>().Use<aspnet_SchemaVersionsEFRepository>();
            For<Iaspnet_UsersRepository>().Use<aspnet_UsersEFRepository>();
            For<Iaspnet_WebEvent_EventsRepository>().Use<aspnet_WebEvent_EventsEFRepository>();
            For<IDeviceRepository>().Use<DeviceEFRepository>();


            // Unit of Work & ObjectContext - StructureMap DI Registration
            For<IUnitOfWork>().Use<EFUnitOfWork>();
            For<IObjectContext>().Use<ObjectContextAdapter>();
            For<ObjectContext>().HybridHttpOrThreadLocalScoped().Use(() => new Entities());
        }
    }
}