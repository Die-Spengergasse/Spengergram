using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IUserFilterBuilder : IEntityFilterBuilder<User>
    {
        new IQueryable<User> EntityList { get; set; }
        new IQueryable<User> Build();

        IUserFilterBuilder ApplyEvaluationGreaterThanFilter(int start);
        IUserFilterBuilder ApplyEvaluationGreaterThanEqualFilter(int start);
        IUserFilterBuilder ApplyEvaluationLowerThanFilter(int start);
        IUserFilterBuilder ApplyEvaluationLowerThanEqualFilter(int start);
        IUserFilterBuilder ApplyFirstNameContainsFilter(string namePart);
        IUserFilterBuilder ApplyLastNameContainsFilter(string namePart);
        IUserFilterBuilder ApplyFirstNameStartsWithFilter(string namePart);
        IUserFilterBuilder ApplyLastNameStartsWithFilter(string namePart);
        IUserFilterBuilder ApplyBirthdateBetweenFilter(DateTime start, DateTime end);
    }
}
