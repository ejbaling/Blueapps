using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the Iaspnet_ProfileRepository
    /// </summary>
	public partial class aspnet_ProfileEFRepository : EFRepository<aspnet_Profile>, Iaspnet_ProfileRepository
	{
        #region Ctors

        public aspnet_ProfileEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}