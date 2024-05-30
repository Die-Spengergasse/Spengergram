namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IEntityFilterBuilder<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> EntityList { get; set; }
        IQueryable<TEntity> Build();
    }
}
