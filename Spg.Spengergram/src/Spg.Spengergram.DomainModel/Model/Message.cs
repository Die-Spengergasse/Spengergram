namespace Spg.Spengergram.DomainModel.Model
{
    public class Message
    {
        public int Id { get; }
        public string Body { get; set; } = string.Empty;
        public DateTime CreationDateTime { get; }
        public User CreatedBy { get; } = default!;

        // Collections
        private List<User> _usersLiked = new();
        public IReadOnlyList<User> UsersLiked => _usersLiked;

        // Navigations
    }
}
