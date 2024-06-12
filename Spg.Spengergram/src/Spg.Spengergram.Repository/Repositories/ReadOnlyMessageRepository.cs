using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Repository.Repositories
{
    /// <summary>
    /// Example for a Repository without generic Base.
    /// Just simple C.R.U.D., and UpdateBuilder, FilterBuilder
    /// This is the Read Part
    /// We just seperate Read/Write through the Interface
    /// </summary>
    public class ReadOnlyMessageRepository : IReadOnlyMessageRepository
    {
        public IQueryable<Message> GetByMessanger(int messsangerId)
        {
            throw new NotImplementedException();
        }
    }
}
