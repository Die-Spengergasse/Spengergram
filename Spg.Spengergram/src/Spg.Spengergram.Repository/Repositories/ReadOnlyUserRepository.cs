using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.Repository.Repositories
{
    public class ReadOnlyUserRepository : ReadOnlyRepository<User, IUserFilterBuilder>, IReadOnlyUserRepository
    {
        public ReadOnlyUserRepository(SqLiteDatabase database, IUserFilterBuilder filterBuilder) 
            : base(database, filterBuilder)
        { }

        // TODO: ??
    }
}
