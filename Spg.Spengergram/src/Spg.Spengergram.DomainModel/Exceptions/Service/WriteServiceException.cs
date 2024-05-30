namespace Spg.Spengergram.DomainModel.Exceptions.Service
{
    public class WriteServiceException : Exception
    {
        public WriteServiceException()
             : base() { }

        public WriteServiceException(string message)
            : base(message) { }

        public WriteServiceException(string message, Exception innerException)
            : base(message, innerException) { }

        public static WriteServiceException FromCreate()
        {
            return new WriteServiceException("Save failed!");
        }
        public static WriteServiceException FromCreate(Exception innerException)
        {
            return new WriteServiceException("Save failed!", innerException);
        }
        public static WriteServiceException FromDelete()
        {
            return new WriteServiceException("Delete failed!");
        }
        public static WriteServiceException FromDelete(Exception innerException)
        {
            return new WriteServiceException("Delete failed!", innerException);
        }
        public static WriteServiceException FromUpdate()
        {
            return new WriteServiceException("Update failed!");
        }
        public static WriteServiceException FromUpdate(Exception innerException)
        {
            return new WriteServiceException("Update failed!", innerException);
        }
    }
}
