namespace Spg.Spengergram.DomainModel.Model
{
    public class Comment
    {
        public CommentId Id { get; private set; } = default!;
        public string Body { get; set; } = string.Empty;
        public DateTime CreationDateTime { get; }

        // Navigations
        public User CreatedByNavigation { get; private set; } = default!;
        public Message MessageNavigation { get; private set; } = default!;
    }
}
