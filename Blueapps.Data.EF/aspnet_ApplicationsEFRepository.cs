using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the Iaspnet_ApplicationsRepository
    /// </summary>
	public partial class aspnet_ApplicationsEFRepository : EFRepository<aspnet_Applications>, Iaspnet_ApplicationsRepository
	{
        #region Ctors

        public aspnet_ApplicationsEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}