namespace Spg.Spengergram.DomainModel.Model
{
    public class Comment
    {
        public CommentId Id { get; private set; } = default!;
        public string Body { get; set; } = string.Empty;
        public DateTime CreationDateTime { get; }

        // Navigations
        public User CreatedByNavigation { get; } = default!;
        public Message MessageNavigation { get; } = default!;

        protected Comment()
        { }
        public Comment(string body, User createdBy)
        {
            Body = body;
            CreatedByNavigation = createdBy;
        }
        public Comment(string body, User createdBy, Message message)
        {
            Body = body;
            CreatedByNavigation = createdBy;
            MessageNavigation = message;
        }
    }
}
