using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            SqLiteDatabase photoContext,
            TFilterBilder filterBuilder,
            TUpdateBuilder updateBuilder)
                : base(photoContext, filterBuilder)
        {
            UpdateBuilder = new UpdateBuilderBase<TEntity, TUpdateBuilder>(updateBuilder);
        }
    }
}
