namespace Spg.Spengergram.DomainModel.Exceptions.Repository
{
    public class WriteRepositoryException : Exception
    {
        public WriteRepositoryException()
             : base() { }

        public WriteRepositoryException(string message)
            : base(message) { }

        public WriteRepositoryException(string message, Exception innerException)
            : base(message, innerException) { }

        public static WriteRepositoryException FromCreate()
        {
            return new WriteRepositoryException("Save failed!");
        }
        public static WriteRepositoryException FromCreate(Exception innerException)
        {
            return new WriteRepositoryException("Save failed!", innerException);
        }
        public static WriteRepositoryException FromDelete()
        {
            return new WriteRepositoryException("Delete failed!");
        }
        public static WriteRepositoryException FromDelete(Exception innerException)
        {
            return new WriteRepositoryException("Delete failed!", innerException);
        }
        public static WriteRepositoryException FromUpdate()
        {
            return new WriteRepositoryException("Update failed!");
        }
        public static WriteRepositoryException FromUpdate(Exception innerException)
        {
            return new WriteRepositoryException("Update failed!", innerException);
        }
    }
}
