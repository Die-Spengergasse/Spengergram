using Spg.Spengergram.DomainModel.Interfaces.Repository;

namespace Spg.Spengergram.Repository
{
    public class UpdateBuilderBase<TEntity, TUpdateBuilder> : IUpdateBuilderBase<TEntity, TUpdateBuilder>
        where TEntity : class
        where TUpdateBuilder : class, IEntityUpdateBuilder<TEntity>
    {
        private TUpdateBuilder _updateBuilder;

        public UpdateBuilderBase(TUpdateBuilder updateBuilder)
        {
            _updateBuilder = updateBuilder;
        }

        public TUpdateBuilder WithEntity(TEntity entity)
        {
            _updateBuilder.Entity = entity;
            return _updateBuilder;
        }
    }
}