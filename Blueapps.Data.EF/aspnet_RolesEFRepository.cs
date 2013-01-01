using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the Iaspnet_RolesRepository
    /// </summary>
	public partial class aspnet_RolesEFRepository : EFRepository<aspnet_Roles>, Iaspnet_RolesRepository
	{
        #region Ctors

        public aspnet_RolesEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}