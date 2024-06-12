namespace Spg.Spengergram.DomainModel.Model
{
    public class Invitation
    {
        public int Id { get; private set; }
        public Guid Guid { get; private set; }
        public User From { get; set; } = default!;
        public User To { get; set; } = default!;
        public DateTime CreationDateTime { get; set; }
    }
}
