namespace Spg.Spengergram.DomainModel.Queries
{
    public record GetUserFilteredQuery(
        string? Filter = null, 
        string? Order = null, 
        int? Page = null, int? 
        Size = null);
}
