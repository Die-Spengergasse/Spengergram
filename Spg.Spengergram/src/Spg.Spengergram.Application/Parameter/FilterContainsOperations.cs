using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Application.Parameter
{
    public class FilterContainsOperations : InterpretParameterBase<User>, IQueryParameter
    {
        private readonly IUserFilterBuilder _userFilterBuilder;
        private object builder;

        public FilterContainsOperations(IUserFilterBuilder userFilterBuilder)
            : base("ct")
        {
            _userFilterBuilder = userFilterBuilder;
        }

        public IUserFilterBuilder Compile(string? queryParameter)
        {
            ForProperty(queryParameter, p => p.FirstName)
                .Use<string>(_userFilterBuilder.ApplyFirstNameContainsFilter);

            ForProperty(queryParameter, p => p.LastName)
                .Use<string>(_userFilterBuilder.ApplyLastNameContainsFilter);

            return _userFilterBuilder;
        }
    }
}
