using System;
using System.Data.Objects;
using Blueapps.Core.Repository;

namespace Blueapps.Data.EF
{
    /// <summary>
    /// The ObjectContext contract.
    /// </summary>
    public interface IObjectContext : IDisposable
    {
        /// <summary>
        /// Creates a new System.Data.Objects.ObjectSet T instance that is used to query, add, modify, and delete objects of the specified entity type.
        /// </summary>
        /// <typeparam name="T">Entity type of the requested System.Data.Objects.ObjectSet T.</typeparam>
        /// <returns>The new System.Data.Objects.ObjectSet T instance.</returns>
        IObjectSet<T> CreateObjectSet<T>() where T : class;

        /// <summary>
        /// Persists all updates to the data store.
        /// </summary>
        void SaveChanges();
    }
}

