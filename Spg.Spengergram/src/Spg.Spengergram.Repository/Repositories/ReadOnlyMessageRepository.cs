using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.Repository.Repositories
{
    /// <summary>
    /// Example for a Repository without generic Base.
    /// Just simple C.R.U.D., and UpdateBuilder, FilterBuilder
    /// This is the Read Part
    /// We just seperate Read/Write through the Interface
    /// </summary>
    public class ReadOnlyMessageRepository : ReadOnlyRepository<User, IUserFilterBuilder>, IReadOnlyUserRepository
    {
        public ReadOnlyMessageRepository(SqLiteDatabase database, IUserFilterBuilder filterBuilder)
            : base(database, filterBuilder)
        { }
    }
}
