using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.DomainModel.Exceptions.Repository;
using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.Repository.Builders
{
    public class MessageUpdateBuilder : IMessageUpdateBuilder
    {
        private readonly SqLiteDatabase _db;

        public Message Entity { get; set; } = default!;

        public MessageUpdateBuilder(SqLiteDatabase db, Message withEntity)
        {
            _db = db;

            Entity = withEntity;
        }

        public IMessageUpdateBuilder WithBody(string newBody)
        {
            Entity.Body = newBody;
            return this;
        }

        public int Save()
        {
            _db.Update(Entity);
            try
            {
                return _db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw WriteRepositoryException.FromUpdate(ex);
            }
        }
    }
}
