using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.DomainModel.Exceptions.Repository;
using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Infrastructure;
using Spg.Spengergram.Repository.Builders;

namespace Spg.Spengergram.Repository.Repositories
{
    /// <summary>
    /// Example for a Repository without generic Base.
    /// Just simple C.R.U.D., and UpdateBuilder, FilterBuilder
    /// This is the Write Part
    /// We just seperate Read/Write through the Interface
    /// </summary>
    public class WritableMessageRepository : IWritableMessageRepository
    {
        private readonly SqLiteDatabase _db;

        public WritableMessageRepository(SqLiteDatabase db)
        {
            _db = db;
        }

        public IMessageUpdateBuilder UpdateBuilder(Message withEntity)
        {
            return new MessageUpdateBuilder(_db, withEntity);
        }

        public int Create(Message newMessage)
        {
            _db.Messages.Add(newMessage);
            try
            {
                return _db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw WriteRepositoryException.FromUpdate(ex);
            }
        }

        public int Delete(MessageId id)
        {
            Message existingMessage = _db.Messages.Find(id) 
                ?? throw WriteRepositoryException.FromDelete();
            _db.Messages.Remove(existingMessage);
            try
            {
                return _db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw WriteRepositoryException.FromDelete(ex);
            }
        }
    }
}
