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
    /// This is the Write Part
    /// We just seperate Read/Write through the Interface
    /// </summary>
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
