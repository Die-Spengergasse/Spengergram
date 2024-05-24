using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Application.Parameter
{
    public class FilterStartsWithOperations : InterpretParameterBase<User>, IQueryParameter
    {
        private readonly IUserFilterBuilder _userFilterBuilder;

        public FilterStartsWithOperations(IUserFilterBuilder userFilterBuilder)
            : base("sw")
        {
            _userFilterBuilder = userFilterBuilder;
        }

        public IUserFilterBuilder Compile(string? queryParameter)
        {
            ForProperty(queryParameter, p => p.FirstName)
                .Use<string>(_userFilterBuilder.ApplyFirstNameStartsWithFilter);

            return _userFilterBuilder;
        }
    }
}
