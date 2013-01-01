using System;
using Blueapps.Core.Repository;

namespace Blueapps.Data.EF
{
    /// <summary>
    /// Entity Framework Unit of Work
    /// </summary>
    public class EFUnitOfWork : IUnitOfWork, IDisposable
    {
        #region Fields

        private readonly IObjectContext _context;

        #endregion Fields

        #region Methods

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        #endregion

        #region IUnitOfWork Members

        /// <summary>
        /// Commits the changes to the data store.
        /// </summary>
        public void Commit()
        {
            _context.SaveChanges();
        }

        #endregion

        #endregion Methods

        #region Ctors

        public EFUnitOfWork(IObjectContext context)
        {
            _context = context;
        }

        #endregion Ctors
    }
}
