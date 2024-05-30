using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.Repository.Repositories
{
    public class WritableUserRepository : ReadWriteRepository<User, IUserFilterBuilder, IUserUpdateBuilder>,
        IWritableUserRepository, IReadOnlyUserRepository
    {
        public WritableUserRepository(SqLiteDatabase db,
            IUserFilterBuilder filterBuilder,
            IUserUpdateBuilder updateBuilder)
                : base(db, filterBuilder, updateBuilder)
        { }
    }
}
