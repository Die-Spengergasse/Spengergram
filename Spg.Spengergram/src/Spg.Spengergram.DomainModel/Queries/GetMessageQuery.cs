namespace Spg.Spengergram.DomainModel.Queries
{
    public record GetMessageQuery(
        Guid MessengerId,
        int? Page = null, int?
        Size = null);
}