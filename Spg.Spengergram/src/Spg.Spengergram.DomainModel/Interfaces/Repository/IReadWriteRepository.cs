namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IReadWriteRepository<TEntity, TUpdateBuilder>
        where TEntity : class
        where TUpdateBuilder : class, IEntityUpdateBuilder<TEntity>
    {
        IUpdateBuilderBase<TEntity, TUpdateBuilder> UpdateBuilder { get; }
    }
}
