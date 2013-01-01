using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the Iaspnet_SchemaVersionsRepository
    /// </summary>
	public partial class aspnet_SchemaVersionsEFRepository : EFRepository<aspnet_SchemaVersions>, Iaspnet_SchemaVersionsRepository
	{
        #region Ctors

        public aspnet_SchemaVersionsEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}