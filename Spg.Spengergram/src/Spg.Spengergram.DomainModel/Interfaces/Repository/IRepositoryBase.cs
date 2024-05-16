using Spg.Spengergram.DomainModel.Interfaces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity>
    {
        TEntity? GetByPK<TKey, TProperty>(
            TKey pk,
            Expression<Func<TEntity, IEnumerable<TProperty>>>? includeCollection = null,
            Expression<Func<TEntity, TProperty>>? includeReference = null)
            where TProperty : class;

        TEntity? GetByPKAndIncudes<TKey, TProperty>(
            TKey pk,
            List<Expression<Func<TEntity, IEnumerable<TProperty>>>?>? includeCollection = null,
            Expression<Func<TEntity, TProperty>>? includeReference = null)
            where TProperty : class;

        T? GetByGuid<T>(Guid guid)
            where T : class, IFindableByGuid;

        T? GetByGuid<T, TProperty>(
            Guid guid,
            List<Expression<Func<T, IEnumerable<TProperty>>>?>? includeCollection = null,
            Expression<Func<T, TProperty>>? includeReference = null)
            where T : class, IFindableByGuid
            where TProperty : class;

        T? GetByEMail<T>(string eMail)
            where T : class, IFindableByEMail;
    }
}
