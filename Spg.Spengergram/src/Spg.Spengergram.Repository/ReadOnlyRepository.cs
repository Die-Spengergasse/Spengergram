using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.Repository
{
    public class ReadOnlyRepository<TEntity, TFilterBilder>
        : RepositoryBase<TEntity>, IReadOnlyRepository<TFilterBilder>
        where TEntity : class
        where TFilterBilder : IEntityFilterBuilder<TEntity>
    {
        public TFilterBilder FilterBuilder { get; set; }

        public ReadOnlyRepository(
            SqLiteDatabase photoContext,
            TFilterBilder filterBuilder)
                : base(photoContext)
        {
            FilterBuilder = filterBuilder;
        }
    }
}
