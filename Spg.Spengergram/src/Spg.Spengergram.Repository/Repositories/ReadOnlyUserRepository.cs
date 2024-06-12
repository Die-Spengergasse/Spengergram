using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.Repository.Repositories
{
    /// <summary>
    /// Example for a Repository with generic Base.
    /// * It uses Base C.R.U.D., 
    /// * It uses UpdateBuilder,
    /// * It uses FilterBuilder
    /// This is the Read Part
    /// We just seperate Read/Write through the Interface
    /// </summary>
    public class ReadOnlyUserRepository : ReadOnlyRepository<User, IUserFilterBuilder>, IReadOnlyUserRepository
    {
        public ReadOnlyUserRepository(SqLiteDatabase database, IUserFilterBuilder filterBuilder) 
            : base(database, filterBuilder)
        { }

        // TODO: ??
    }
}
