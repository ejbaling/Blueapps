using System;
using System.Linq;
using System.Collections.Generic;
using Blueapps.Core.Repository;
using Blueapps.Core.Domain;

namespace Blueapps.Data.EF
{	
    /// <summary>
    /// Entity Framework implementation of the IDeviceRepository
    /// </summary>
	public partial class DeviceEFRepository : EFRepository<Device>, IDeviceRepository
	{
        #region Ctors

        public DeviceEFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors
	}
}
