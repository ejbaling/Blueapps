namespace Blueapps.Core.Repository
{	
	/// <summary>
    /// Unit of Work Contract
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Commits the changes to the data store.
        /// </summary>
        void Commit();
    }
}

