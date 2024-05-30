using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Repository.Builders
{
    public class UserFilterBuilder : IEntityFilterBuilder<User>, IUserFilterBuilder
    {
        public IQueryable<User> EntityList { get; set; }

        public UserFilterBuilder(IQueryable<User> entityList)
        {
            EntityList = entityList;
        }

        public IUserFilterBuilder ApplyEvaluationGreaterThanFilter(int start)
        {
            EntityList = EntityList.Where(x => x.Evaluation > start);
            return this;
        }
        public IUserFilterBuilder ApplyEvaluationGreaterThanEqualFilter(int start)
        {
            EntityList = EntityList.Where(x => x.Evaluation >= start);
            return this;
        }
        public IUserFilterBuilder ApplyEvaluationLowerThanFilter(int start)
        {
            EntityList = EntityList.Where(x => x.Evaluation < start);
            return this;
        }
        public IUserFilterBuilder ApplyEvaluationLowerThanEqualFilter(int start)
        {
            EntityList = EntityList.Where(x => x.Evaluation <= start);
            return this;
        }
        public IUserFilterBuilder ApplyFirstNameContainsFilter(string namePart)
        {
            EntityList = EntityList.Where(x => x.FirstName.Trim().ToLower()
                .Contains(namePart.Trim().ToLower()));
            return this;
        }
        public IUserFilterBuilder ApplyLastNameContainsFilter(string namePart)
        {
            EntityList = EntityList.Where(x => x.LastName.Trim().ToLower()
                .Contains(namePart.Trim().ToLower()));
            return this;
        }
        public IUserFilterBuilder ApplyFirstNameStartsWithFilter(string namePart)
        {
            EntityList = EntityList.Where(x => x.FirstName.Trim().ToLower()
                .StartsWith(namePart.Trim().ToLower()));
            return this;
        }
        public IUserFilterBuilder ApplyLastNameStartsWithFilter(string namePart)
        {
            EntityList = EntityList.Where(x => x.LastName.Trim().ToLower()
                .StartsWith(namePart.Trim().ToLower()));
            return this;
        }
        public IUserFilterBuilder ApplyBirthdateBetweenFilter(DateTime start, DateTime end)
        {
            EntityList = EntityList.Where(x => x.BirthDate > start && x.BirthDate < end);
            return this;
        }

        public IQueryable<User> Build()
        {
            return EntityList;
        }
    }
}
