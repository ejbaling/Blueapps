using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Blueapps.Core.Repository
{
    /// <summary>
    /// Generic Read-Only Repository Contract
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadOnlyRepository<T> where T : class
    {
        /// <summary>
        /// Gets an IQueryable sequence of entities of type T.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Queryable();

        /// <summary>
        /// Gets an IEnumerable sequence of all entites of type T.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> All();

        /// <summary>
        /// Get an IEnumerable sequence of entities of type T filtered on the @where predicate.
        /// </summary>
        /// <param name="where">The where predicate.</param>
        /// <returns></returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> where);

        /// <summary>
        /// Gets a single entity in a sequence of entities of type T using the filtered @where predicate.
        /// </summary>
        /// <param name="where">The where predicate.</param>
        /// <returns></returns>
        T Single(Expression<Func<T, bool>> where);

        /// <summary>
        /// Gets the first entity in a sequence of entities of type T using the filtered @where predicate.
        /// </summary>
        /// <param name="where">The where predicate.</param>
        /// <returns></returns>
        T First(Expression<Func<T, bool>> where);

        /// <summary>
        /// Gets a single entity (or default of entity of type T) in a sequence of entities of type T using the filtered @where predicate.
        /// </summary>
        /// <param name="where">The where predicate.</param>
        /// <returns></returns>
        T SingleOrDefault(Expression<Func<T, bool>> where);

        /// <summary>
        /// Gets a first entity (or default entity of type T) in a sequence of entities of type T using the filtered @where predicate.
        /// </summary>
        /// <param name="where">The where predicate.</param>
        /// <returns></returns>
        T FirstOrDefault(Expression<Func<T, bool>> where);
    }
}

