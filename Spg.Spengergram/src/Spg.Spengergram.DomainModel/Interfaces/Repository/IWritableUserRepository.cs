using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IWritableUserRepository : IReadWriteRepository<User, IUserUpdateBuilder>
    {

    }
}
