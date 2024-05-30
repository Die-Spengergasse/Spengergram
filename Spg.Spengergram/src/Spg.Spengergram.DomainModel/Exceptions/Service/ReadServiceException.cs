namespace Spg.Spengergram.DomainModel.Exceptions.Service
{
    public class ReadServiceException : Exception
    {
        public ReadServiceException()
             : base() { }

        public ReadServiceException(string message)
            : base(message) { }

        public ReadServiceException(string message, Exception innerException)
            : base(message, innerException) { }

        public static ReadServiceException FromNotFound()
        {
            return new ReadServiceException("Entity not found!");
        }
    }
}