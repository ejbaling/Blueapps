
using Blueapps.Core.Repository;

namespace Blueapps.Data.EF
{
    /// <summary>
    /// Entity Framework Respository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EFRepository<T> : EFReadOnlyRepository<T>, IRepository<T> where T : class
    {
        #region Ctors

        public EFRepository(IObjectContext context) : base(context)
        {
        }

        #endregion Ctors

        #region Methods

        /// <summary>
        /// Adds the specified entity to the respository of type T.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        public void Add(T entity)
        {
            ObjectSet.AddObject(entity);
        }

        /// <summary>
        /// Deletes the specified entity to the respository of type T.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        public void Delete(T entity)
        {
            ObjectSet.DeleteObject(entity);
        }

        /// <summary>
        /// Attaches the specified entity to the respository of type T.
        /// </summary>
        /// <param name="entity">The entity to attach.</param>
        public void Attach(T entity)
        {
            ObjectSet.Attach(entity);
        }

        #endregion Methods
    }
}

