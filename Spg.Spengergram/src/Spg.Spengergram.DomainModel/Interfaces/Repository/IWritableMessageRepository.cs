using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IWritableMessageRepository
    {
        void Create(Message newMessage);

        IMessageUpdateBuilder UpdateBuilder { get; }

        void Delete(int id);
    }
}
