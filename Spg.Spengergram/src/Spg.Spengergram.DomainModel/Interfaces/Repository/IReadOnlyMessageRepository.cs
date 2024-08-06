using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IReadOnlyMessageRepository
    {
        IQueryable<Message> GetByMessanger(Guid messsangerId);
    }
}
