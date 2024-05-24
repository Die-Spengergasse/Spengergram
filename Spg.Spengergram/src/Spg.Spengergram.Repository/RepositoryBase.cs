using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.DomainModel.Exceptions.Repository;
using Spg.Spengergram.DomainModel.Interfaces.Entity;
using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.Infrastructure;
using System.Linq.Expressions;

namespace Spg.Spengergram.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class
    {
        private readonly SqLiteDatabase _database;

        public RepositoryBase(SqLiteDatabase database)
        {
            _database = database;
        }

        public TEntity? GetByPK<TKey, TProperty>(
            TKey pk,
            Expression<Func<TEntity, IEnumerable<TProperty>>>? includeCollection = null,
            Expression<Func<TEntity, TProperty>>? includeReference = null)
            where TProperty : class
        {
            TEntity? entity = _database.Set<TEntity>().Find(pk);
            if (entity is not null)
            {
                if (includeCollection is not null)
                {
                    _database.Entry(entity).Collection(includeCollection).Load();
                }
                if (includeReference is not null)
                {
                    _database.Entry(entity).Reference(includeReference!).Load();
                }
            }
            return entity;
        }

        public TEntity? GetByPKAndIncudes<TKey, TProperty>(
            TKey pk,
            List<Expression<Func<TEntity, IEnumerable<TProperty>>>?>? includeCollection = null,
            Expression<Func<TEntity, TProperty>>? includeReference = null)
            where TProperty : class
        {
            TEntity? entity = _database.Set<TEntity>().Find(pk);
            if (entity is not null)
            {
                if (includeCollection is not null)
                {
                    foreach (Expression<Func<TEntity, IEnumerable<TProperty>>>? item in includeCollection)
                    {
                        if (item is not null)
                        {
                            _database.Entry(entity).Collection(item).Load();
                        }
                    }
                }
                if (includeReference is not null)
                {
                    _database.Entry(entity).Reference(includeReference!).Load();
                }
            }
            return entity;
        }

        public T? GetByGuid<T>(Guid guid)
            where T : class, IFindableByGuid
        {
            return _database
                .Set<T>()
                .SingleOrDefault(e => e.Guid == guid);
        }

        public T? GetByGuid<T, TProperty>(
            Guid guid,
            List<Expression<Func<T, IEnumerable<TProperty>>>?>? includeCollection = null,
            Expression<Func<T, TProperty>>? includeReference = null)
            where T : class, IFindableByGuid
            where TProperty : class
        {
            T? entity = _database
                .Set<T>()
                .SingleOrDefault(e => e.Guid == guid);

            if (includeCollection is not null)
            {
                foreach (Expression<Func<T, IEnumerable<TProperty>>>? item in includeCollection)
                {
                    if (item is not null)
                    {
                        _database.Entry(entity).Collection(item).Load();
                    }
                }
            }
            if (includeReference is not null)
            {
                _database.Entry(entity).Reference(includeReference!).Load();
            }

            return entity;
        }

        public T? GetByEMail<T>(string eMail)
            where T : class, IFindableByEMail
        {
            return _database
                .Set<T>()
                .SingleOrDefault(e => e.EMailAddress.Value == eMail);
        }

        public void Create(TEntity newEntity)
        {
            _database.Set<TEntity>().Add(newEntity);
            try
            {
                _database.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw WriteRepositoryException.FromCreate(ex);
            }
        }

        public void Delete<TId, RichType>(IRichType<TId> richType)
        {
            TEntity foundEntity = _database.Set<TEntity>().Find(richType) ??
                throw WriteRepositoryException.FromDelete();

            _database.Set<TEntity>().Remove(foundEntity);
            try
            {
                _database.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw WriteRepositoryException.FromDelete(ex);
            }
        }
    }
}