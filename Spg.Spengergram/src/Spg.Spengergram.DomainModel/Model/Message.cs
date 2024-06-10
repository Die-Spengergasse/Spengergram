namespace Spg.Spengergram.DomainModel.Model
{
    public class Message
    {
        public int Id { get; }
        public string Body { get; set; } = string.Empty;
        public DateTime CreationDateTime { get; }

        // Collections
        private List<Reaction> _reactions = new();
        public IReadOnlyList<Reaction> Reactions => _reactions;

        // Navigations
        public User CreatedBy { get; } = default!;
    }
}
