using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.Repository
{
    public class ReadWriteRepository<TEntity, TFilterBilder, TUpdateBuilder>
        : ReadOnlyRepository<TEntity, TFilterBilder>, IReadWriteRepository<TEntity, TUpdateBuilder>
        where TEntity : class
        where TFilterBilder : class, IEntityFilterBuilder<TEntity>
        where TUpdateBuilder : class, IEntityUpdateBuilder<TEntity>
    {
        public IUpdateBuilderBase<TEntity, TUpdateBuilder> UpdateBuilder { get; }

        public ReadWriteRepository(
            SqLiteDatabase database,
            TFilterBilder filterBuilder,
            TUpdateBuilder updateBuilder)
                : base(database, filterBuilder)
        {
            UpdateBuilder = new UpdateBuilderBase<TEntity, TUpdateBuilder>(updateBuilder);
        }
    }
}
