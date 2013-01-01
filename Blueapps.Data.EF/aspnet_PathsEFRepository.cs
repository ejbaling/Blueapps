using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the Iaspnet_PathsRepository
    /// </summary>
	public partial class aspnet_PathsEFRepository : EFRepository<aspnet_Paths>, Iaspnet_PathsRepository
	{
        #region Ctors

        public aspnet_PathsEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}