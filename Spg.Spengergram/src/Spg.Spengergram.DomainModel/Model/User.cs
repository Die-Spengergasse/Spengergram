using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Interfaces.Entity;

namespace Spg.Spengergram.DomainModel.Model
{
    public class User : IFindableByGuid, IFindableByEMail
    {
        /// <summary>
        /// PK, Richt Typed, Numerical (int) and auto increment
        /// Never tell Client!
        /// see: Convention over Configuration
        /// </summary>
        public UserId Id { get; private set; } = default!;
        /// <summary>
        /// Worst: api/users/4711 !!!! (Who will be: 4712, 4713, 4714, ...)
        /// Better: api/users/e0bbc0c1-68e6-4230-813e-4bd1db18cc0e
        /// </summary>
        public Guid Guid { get; private set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Username Username { get; private set; } = default!; // should it be changable?
        public EMailAddress EMailAddress { get; set; } = default!;
        public int Evaluation { get; set; } = 0;
        public DateTime BirthDate { get; private set; } // should it be changable? (Change BirthDate?!?!?!)

        // Collections (!Secure Lists! Data only comes from Database.
        // Make this readonly and just getters, so other Developers
        // cannot manipulate the Collections)
        private List<PhoneNumber> _phoneNumbers = new();
        public IReadOnlyList<PhoneNumber> PhoneNumbers => _phoneNumbers;

        private List<Messenger> _messengers = new();
        public IReadOnlyList<Messenger> Messages => _messengers;

        private List<Reaction> _reactions = new();
        public IReadOnlyList<Reaction> Reactions => _reactions;

        // Navigations
        public Messenger MessengerNavigation { get; } = default!;

        /// <summary>
        /// Re-generate the overloaded default contructor. 
        /// The OR-Mapper needs it. Why? (Answer this during Lession)
        /// </summary>
        protected User()
        { }
        /// <summary>
        /// Use clean Constructors. Every Entity must instantiate with valid data.
        /// </summary>
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
        public User(
            Guid guid, string firstName, string lastName, DateTime birthDate,
            Username username, EMailAddress eMailAddress, Messenger messenger)
        {
            Guid = guid;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            EMailAddress = eMailAddress;
            BirthDate = birthDate;
            MessengerNavigation = messenger;
        }

        /// <summary>
        /// The Entity should map itself into different DTOs
        /// </summary>
        /// <returns></returns>
        public UserDto ToDto()
        {
            return new UserDto(Guid, FirstName, LastName);
        }
    }
}
