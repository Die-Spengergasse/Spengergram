using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.DomainModel.Exceptions.Repository;
using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.Repository.Builders
{
    public class UserUpdateBuilder : IUserUpdateBuilder
    {
        private readonly SqLiteDatabase _db;

        public User Entity { get; set; } = default!;

        public UserUpdateBuilder(SqLiteDatabase db)
        {
            _db = db;
        }

        public IUserUpdateBuilder WithFirstName(string firstName)
        {
            Entity.FirstName = firstName;
            return this;
        }

        public IUserUpdateBuilder WithLastName(string lastName)
        {
            Entity.LastName = lastName;
            return this;
        }

        public int Save()
        {
            _db.Update(Entity);
            try
            {
                return _db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw WriteRepositoryException.FromUpdate(ex);
            }
        }
    }
}
