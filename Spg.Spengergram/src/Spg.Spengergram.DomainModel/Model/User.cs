using Spg.Spengergram.DomainModel.Interfaces.Entity;

namespace Spg.Spengergram.DomainModel.Model
{
    public class User : IFindableByGuid, IFindableByEMail
    {
        public UserId Id { get; }
        public Guid Guid { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Username Username { get; }
        public EMailAddress EMailAddress { get; set; }
        
        private List<PhoneNumber> _phoneNumbers = new();
        public IReadOnlyList<PhoneNumber> PhoneNumbers => _phoneNumbers;

        protected User()
        { }
        public User(
            Guid guid, string firstName, string lastName, 
            Username username, EMailAddress eMailAddress)
        {
            Guid = guid;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            EMailAddress = eMailAddress;
        }
    }
}
