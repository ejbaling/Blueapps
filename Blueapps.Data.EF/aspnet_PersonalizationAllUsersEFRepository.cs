using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the Iaspnet_PersonalizationAllUsersRepository
    /// </summary>
	public partial class aspnet_PersonalizationAllUsersEFRepository : EFRepository<aspnet_PersonalizationAllUsers>, Iaspnet_PersonalizationAllUsersRepository
	{
        #region Ctors

        public aspnet_PersonalizationAllUsersEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}