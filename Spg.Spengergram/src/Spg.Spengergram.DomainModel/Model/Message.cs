namespace Spg.Spengergram.DomainModel.Model
{
    public class Message
    {
        public MessageId Id { get; private set; } = default!;
        public string Body { get; set; } = string.Empty;
        public DateTime CreationDateTime { get; private set; }

        protected Message()
        { }
        public Message(string body)
        {
            Body = body;
        }
        public Message(string body, Messenger messenger)
        {
            Body = body;
            MessengerNavigation = messenger;
        }

        // Collections
        private List<Reaction> _reactions = new();
        public IReadOnlyList<Reaction> Reactions => _reactions;

        private List<Comment> _comments = new();
        public IReadOnlyList<Comment> Comments => _comments;

        // Navigations
        public User CreatedByNavigation { get; private set; } = default!;
        public Messenger MessengerNavigation { get; private set; } = default!;
    }
}
