using System.Data.Objects;
using System.Linq;
using Blueapps.Core.Repository;

namespace Blueapps.Data.EF
{
	/// <summary>
    /// IQueryable Extensions class.
    /// </summary>
    public static class RepositoryIQueryableExtensions
    {
		/// <summary>
        /// Eager Loading 'Include' method to provide eager loading for Entity Framework-based data models.
        /// For more information on this extension method: Testability and Entity Framework 4.0 
		/// <see cref="http://msdn.microsoft.com/en-us/ff714955.aspx"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static IQueryable<T> Include<T>(this IQueryable<T> source, string path) where T : class
        {
            var objectQuery = source as ObjectQuery<T>;
            return objectQuery != null ? objectQuery.Include(path) : source;
        }
    }
}
