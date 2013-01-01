using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the Iaspnet_PersonalizationPerUserRepository
    /// </summary>
	public partial class aspnet_PersonalizationPerUserEFRepository : EFRepository<aspnet_PersonalizationPerUser>, Iaspnet_PersonalizationPerUserRepository
	{
        #region Ctors

        public aspnet_PersonalizationPerUserEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}