using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IUserUpdateBuilder : IEntityUpdateBuilder<User>
    {
        IUserUpdateBuilder WithFirstName(string firstName);
        IUserUpdateBuilder WithLastName(string lastName);
    }
}
