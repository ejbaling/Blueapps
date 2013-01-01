

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blueapps.Core.Repository
{ 
    /// <summary>
    /// Generic Repository Contract.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> : IReadOnlyRepository<T> where T : class
    {
        /// <summary>
        /// Adds the specified entity to the respository of type T.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        void Add(T entity);

        /// <summary>
        /// Deletes the specified entity to the respository of type T.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        void Delete(T entity);

        /// <summary>
        /// Attaches the specified entity to the respository of type T.
        /// </summary>
        /// <param name="entity">The entity to attach.</param>
        void Attach(T entity);
    }
}

