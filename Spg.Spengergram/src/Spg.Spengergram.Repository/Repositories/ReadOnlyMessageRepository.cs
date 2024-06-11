using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Repository.Repositories
{
    public class ReadOnlyMessageRepository : IReadOnlyMessageRepository
    {
        public IQueryable<Message> GetByMessanger(int messsangerId)
        {
            throw new NotImplementedException();
        }
    }
}
