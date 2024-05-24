using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Application.Parameter
{
    public class FilterGreaterThanOperations : InterpretParameterBase<User>, IQueryParameter
    {
        private readonly IUserFilterBuilder _userFilterBuilder;

        public FilterGreaterThanOperations(IUserFilterBuilder userFilterBuilder)
            : base("gt")
        {
            _userFilterBuilder = userFilterBuilder;
        }

        public IUserFilterBuilder Compile(string? queryParameter)
        {
            ForProperty(queryParameter, p => p.Evaluation)
                .Use<int>(_userFilterBuilder.ApplyEvaluationGreaterThanFilter);

            return _userFilterBuilder;
        }
    }
}
