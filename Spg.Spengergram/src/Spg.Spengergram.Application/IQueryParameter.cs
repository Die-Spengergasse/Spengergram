using Spg.Spengergram.DomainModel.Interfaces.Repository;

namespace Spg.Spengergram.Application
{
    public interface IQueryParameter
    {
        IUserFilterBuilder Compile(string queryParameter);
    }
}
