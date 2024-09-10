using Spg.Spengergram.DomainModel.Dtos;
using System.Xml.Linq;

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
        public User? CreatedByNavigation { get; set; } = default!;
        public Messenger MessengerNavigation { get; private set; } = default!;

        /// <summary>
        /// Verifier: > 5 verifyed Posts, they are visible
        /// Rate-Limitation: max. n Posts per Day and Downsizing
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public Message AddComment(Comment comment)
        {
            if (comment != null)
            {
                _comments.Add(new Comment(comment.Body, comment.CreatedByNavigation, this));
            }
            return this;
        }

        public Message AddComments(IEnumerable<Comment> comments)
        {
            _comments.AddRange(
                comments
                    .Where(c => c is not null)
                    .Select(c => new Comment(c.Body, c.CreatedByNavigation, this))
                );
            return this;
        }

        /// <summary>
        /// The Entity should map itself into different DTOs
        /// </summary>
        /// <returns></returns>
        public MessageDto ToDto()
        {
            return new MessageDto(Body, CreationDateTime);
        }
    }
}
