namespace Spg.Spengergram.DomainModel.Exceptions.Repository
{
    public class ReadRepositoryException : Exception
    {
        public ReadRepositoryException()
             : base() { }

        public ReadRepositoryException(string message)
            : base(message) { }

        public ReadRepositoryException(string message, Exception innerException)
            : base(message, innerException) { }

        public static ReadRepositoryException FromRead()
        {
            return new ReadRepositoryException("Read failed!");
        }
    }
}
