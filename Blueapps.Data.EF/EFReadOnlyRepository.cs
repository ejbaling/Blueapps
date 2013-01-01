using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using Blueapps.Core.Repository;

namespace Blueapps.Data.EF
{
    /// <summary>
    /// Entity Framework Read-Only Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EFReadOnlyRepository<T> : IReadOnlyRepository<T> where T : class
    {
        #region Fields
        protected readonly IObjectSet<T> ObjectSet;
        #endregion Fields

        #region Ctors
        public EFReadOnlyRepository(IObjectContext context)
        {
            this.ObjectSet = context.CreateObjectSet<T>();
        }

        #endregion Ctors

        #region Properties
        #endregion Properties

        #region Methods
        /// <summary>
        /// Gets an IQueryable sequence of entities of type T.
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Queryable()
        {
            return this.ObjectSet;
        }

        /// <summary>
        /// Gets an IEnumerable sequence of all entites of type T.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> All()
        {
            return this.ObjectSet.ToList();
        }

        /// <summary>
        /// Get an IEnumerable sequence of entities of type T filtered on the @where predicate.
        /// </summary>
        /// <param name="where">The where predicate.</param>
        /// <returns></returns>
        public IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            return this.ObjectSet.Where(where);
        }

        /// <summary>
        /// Gets a single entity in a sequence of entities of type T using the filtered @where predicate.
        /// </summary>
        /// <param name="where">The where predicate.</param>
        /// <returns></returns>
        public T Single(Expression<Func<T, bool>> where)
        {
            return this.ObjectSet.Single(where);
        }

        /// <summary>
        /// Gets the first entity in a sequence of entities of type T using the filtered @where predicate.
        /// </summary>
        /// <param name="where">The where predicate.</param>
        /// <returns></returns>
        public T First(Expression<Func<T, bool>> where)
        {
            return this.ObjectSet.First(where);
        }

        /// <summary>
        /// Gets a single entity (or default of entity of type T) in a sequence of entities of type T using the filtered @where predicate.
        /// </summary>
        /// <param name="where">The where predicate.</param>
        /// <returns></returns>
        public T SingleOrDefault(Expression<Func<T, bool>> where)
        {
            return this.ObjectSet.SingleOrDefault(where);
        }

        /// <summary>
        /// Gets a first entity (or default entity of type T) in a sequence of entities of type T using the filtered @where predicate.
        /// </summary>
        /// <param name="where">The where predicate.</param>
        /// <returns></returns>
        public T FirstOrDefault(Expression<Func<T, bool>> where)
        {
            return this.ObjectSet.FirstOrDefault(where);
        }
        #endregion Methods
    }
}

