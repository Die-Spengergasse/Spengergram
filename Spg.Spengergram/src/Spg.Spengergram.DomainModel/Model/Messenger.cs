namespace Spg.Spengergram.DomainModel.Model
{
    public class Messenger
    {
        public MessengerId Id { get; private set; } = default!;
        public Guid Guid { get; private set; }

        protected Messenger()
        { }
        public Messenger(Guid guid)
        {
            Guid = guid;
        }

        // Collections
        private List<User> _users = new();
        public IReadOnlyList<User> Users => _users;

        private List<Message> _messages = new();
        public IReadOnlyList<Message> Messages => _messages;

        public Messenger AddMessages(IEnumerable<Message> messages)
        {
            _messages.AddRange(
                messages
                    .Where(m => m is not null)
                    .Select(m => new Message(m.Body, this))
            );
            return this;
        }

        public Messenger AddUsers(IEnumerable<User> users)
        {
            _users.AddRange(
                users
                    .Where(u => u is not null)
                    .Select(u => new User(
                        u.Guid, u.FirstName, u.LastName, u.BirthDate, 
                        u.Username, u.EMailAddress, this))
            );
            return this;
        }
    }
}
