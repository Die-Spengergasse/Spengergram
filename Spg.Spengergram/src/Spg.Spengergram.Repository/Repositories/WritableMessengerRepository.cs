using Spg.Spengergram.DomainModel.Interfaces.Entity;
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
    /// This is the Write Part
    /// We just seperate Read/Write through the Interface
    /// </summary>
    public class WritableMessengerRepository : RepositoryBase<Messenger>, IWritableMessengerRepository
    {
        public WritableMessengerRepository(SqLiteDatabase database)
            : base(database)
        { }

        public void Delete(MessengerId richType)
        {
            Delete<int, MessageId>(richType);
        }
    }
}