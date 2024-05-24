using MediatR;
using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Queries;

namespace Spg.Spengergram.Application.UseCases.UserStories.Queries
{
    public class GetUserFilteredModel : IRequest<IQueryable<UserDto>>
    {
        public GetUserFilteredQuery Query { get; }

        public GetUserFilteredModel(GetUserFilteredQuery query)
        {
            Query = query;
        }
    }
}
