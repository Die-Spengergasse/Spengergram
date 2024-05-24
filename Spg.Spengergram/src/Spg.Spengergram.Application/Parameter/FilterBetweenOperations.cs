using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Application.Parameter
{
    public class FilterBetweenOperations : InterpretParameterBase<User>, IQueryParameter
    {
        private readonly IUserFilterBuilder _userFilterBuilder;

        public FilterBetweenOperations(IUserFilterBuilder userFilterBuilder)
            : base("bw")
        {
            _userFilterBuilder = userFilterBuilder;
        }

        public IUserFilterBuilder Compile(string? queryParameter)
        {
            ForProperty(queryParameter, p => p.BirthDate)
                .Use<DateTime, DateTime>(_userFilterBuilder.ApplyBirthdateBetweenFilter);

            return _userFilterBuilder;
        }
    }
}
