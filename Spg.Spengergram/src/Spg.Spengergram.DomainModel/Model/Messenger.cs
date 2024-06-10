namespace Spg.Spengergram.DomainModel.Model
{
    public class Messenger
    {
        public int Id { get; }
        public Guid Guid { get; }

        // Collections
        private List<User> _users = new();
        public IReadOnlyList<User> Users => _users;

        private List<Message> _messages = new();
        public IReadOnlyList<Message> Messages => _messages;
    }
}
