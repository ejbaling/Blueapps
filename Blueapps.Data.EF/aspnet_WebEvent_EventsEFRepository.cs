using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the Iaspnet_WebEvent_EventsRepository
    /// </summary>
	public partial class aspnet_WebEvent_EventsEFRepository : EFRepository<aspnet_WebEvent_Events>, Iaspnet_WebEvent_EventsRepository
	{
        #region Ctors

        public aspnet_WebEvent_EventsEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}