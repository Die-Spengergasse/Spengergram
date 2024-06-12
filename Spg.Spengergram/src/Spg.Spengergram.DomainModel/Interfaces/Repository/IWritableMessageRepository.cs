using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IWritableMessageRepository
    {
        IMessageUpdateBuilder UpdateBuilder(Message withEntity);

        int Create(Message newMessage);
        int Delete(MessageId id);
    }
}
