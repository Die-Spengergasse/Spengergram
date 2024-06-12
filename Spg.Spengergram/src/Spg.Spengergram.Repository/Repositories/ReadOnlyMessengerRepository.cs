using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.Repository.Repositories
{
    /// <summary>
    /// Example for Repository with generic Base
    /// * It uses Base C.R.U.D., 
    /// * No UpdateBuilder,
    /// * No FilterBuilder
    /// This is the Read Part
    /// We just seperate Read/Write through the Interface
    /// </summary>
    public class ReadOnlyMessengerRepository : RepositoryBase<Messenger>, IRepositoryBase<Messenger>
    {
        public ReadOnlyMessengerRepository(SqLiteDatabase database)
            : base(database)
        { }
    }
}
