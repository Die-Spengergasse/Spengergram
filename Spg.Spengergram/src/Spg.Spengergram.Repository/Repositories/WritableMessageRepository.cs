using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Infrastructure;
using Spg.Spengergram.Repository.Builders;

namespace Spg.Spengergram.Repository.Repositories
{
    public class WritableMessageRepository : IWritableMessageRepository
    {
        private readonly SqLiteDatabase _db;

        public Message Entity { get; set; } = default!;

        public IMessageUpdateBuilder UpdateBuilder { get; }

        public WritableMessageRepository(SqLiteDatabase db, Message withEntity)
        {
            UpdateBuilder = new MessageUpdateBuilder(db);
            _db = db;
        }

        public void Create(Message newMessage)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
