using System.Data.Objects;
using Blueapps.Core.Repository;

namespace Blueapps.Data.EF
{
    /// <summary>
    /// ObjectContext Adapter class.
    /// </summary>
    public class ObjectContextAdapter : IObjectContext
    {
        #region Fields

        private readonly ObjectContext _context;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Creates a new System.Data.Objects.ObjectSet T instance that is used to query, add, modify, and delete objects of the specified entity type.
        /// </summary>
        /// <typeparam name="T">Entity type of the requested System.Data.Objects.ObjectSet T.</typeparam>
        /// <returns>The new System.Data.Objects.ObjectSet T instance.</returns>
        public IObjectSet<T> CreateObjectSet<T>() where T : class
        {
            return _context.CreateObjectSet<T>();
        }

        /// <summary>
        /// Persists all updates to the data store.
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }

        #endregion Methods

        #region Ctors

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectContextAdapter"/> class.
        /// </summary>
        /// <param name="context">The object context.</param>
        public ObjectContextAdapter(ObjectContext context)
        {
            _context = context;
        }

        #endregion Ctors
    }
}
