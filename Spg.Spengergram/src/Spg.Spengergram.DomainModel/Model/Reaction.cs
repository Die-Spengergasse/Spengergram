namespace Spg.Spengergram.DomainModel.Model
{
    public enum ReactionType { Smile, Lough, LoL, ThumpUp }

    public class Reaction
    {
        public int Id { get; }
        public ReactionType ReactionType { get; set; }

        // Navigations
        public User UserNavigation { get; set; } = default!;
        public Message MessageNavigation { get; set; } = default!;
    }
}
