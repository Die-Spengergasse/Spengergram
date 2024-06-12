using Spg.Spengergram.DomainModel.Interfaces.Entity;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IWritableMessengerRepository
    {
        void Create(Messenger newMessage);
        void Delete(MessengerId richType);
    }
}
