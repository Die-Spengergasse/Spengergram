using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Interfaces.Entity;

namespace Spg.Spengergram.DomainModel.Model
{
    public class User : IFindableByGuid, IFindableByEMail
    {
        public UserId Id { get; } = default!;
        public Guid Guid { get; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Username Username { get; } = default!;
        public EMailAddress EMailAddress { get; set; } = default!;
        public int Evaluation { get; set; } = 0;
        public DateTime BirthDate { get; set; }

        // Collections
        private List<PhoneNumber> _phoneNumbers = new();
        public IReadOnlyList<PhoneNumber> PhoneNumbers => _phoneNumbers;

        private List<Messenger> _messengers = new();
        public IReadOnlyList<Messenger> Messages => _messengers;

        // Navigations

        protected User()
        { }
        public User(
            Guid guid, string firstName, string lastName, DateTime birthDate,
            Username username, EMailAddress eMailAddress)
        {
            Guid = guid;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            EMailAddress = eMailAddress;
            BirthDate = birthDate;
        }

        public UserDto ToDto()
        {
            return new UserDto(Guid, FirstName, LastName);
        }
    }
}
