using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.Repository
{
    public class ReadOnlyRepository<TEntity, TFilterBilder>
        : RepositoryBase<TEntity>, IReadOnlyRepository<TEntity, TFilterBilder>
        where TEntity : class
        where TFilterBilder : IEntityFilterBuilder<TEntity>
    {
        public TFilterBilder FilterBuilder { get; set; }

        public ReadOnlyRepository(
            SqLiteDatabase database,
            TFilterBilder filterBuilder)
                : base(database)
        {
            FilterBuilder = filterBuilder;
        }
    }
}
