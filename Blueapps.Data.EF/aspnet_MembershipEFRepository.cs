using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the Iaspnet_MembershipRepository
    /// </summary>
	public partial class aspnet_MembershipEFRepository : EFRepository<aspnet_Membership>, Iaspnet_MembershipRepository
	{
        #region Ctors

        public aspnet_MembershipEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}