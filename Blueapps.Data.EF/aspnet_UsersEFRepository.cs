using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the Iaspnet_UsersRepository
    /// </summary>
	public partial class aspnet_UsersEFRepository : EFRepository<aspnet_Users>, Iaspnet_UsersRepository
	{
        #region Ctors

        public aspnet_UsersEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}