using System.Web.Mvc;
using StructureMap;
using Blueapps.Data.EF;
using Blueapps.Infrastructure.Services;

namespace Blueapps.Web.Bootstrap
{
    public static class StructureMapContainerSetup
    {
        public static void Setup()
        {
            IContainer container = new Container(
                x =>
                {
                    x.AddRegistry(new EFRepositoryRegistry());
                    x.AddRegistry(new ServicesRegistry());
                }
                );

            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
        }
    }
}