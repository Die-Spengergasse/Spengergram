namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IUpdateBuilderBase<TEntity, TUpdateBuilder>
            where TEntity : class
            where TUpdateBuilder : class
    {
        TUpdateBuilder WithEntity(TEntity photo);
    }
}
