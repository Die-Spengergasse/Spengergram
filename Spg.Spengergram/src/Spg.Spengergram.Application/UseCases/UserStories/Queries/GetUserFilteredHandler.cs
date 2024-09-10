using MediatR;
using Spg.Spengergram.Application.Parameter;
using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Interfaces.Repository;

namespace Spg.Spengergram.Application.UseCases.UserStories.Queries
{
    public class GetUserFilteredHandler : IRequestHandler<GetUserFilteredModel, IQueryable<UserDto>>
    {
        private readonly IReadOnlyUserRepository _userRepository;

        public GetUserFilteredHandler(IReadOnlyUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<IQueryable<UserDto>> Handle(GetUserFilteredModel request, CancellationToken cancellationToken)
        {
            IUserFilterBuilder builder =
                _userRepository
                .FilterBuilder;

            List<IQueryParameter> operations =
            [
                new FilterContainsOperations(builder),
                new FilterStartsWithOperations(builder),
                new FilterGreaterThanOperations(builder),
                new FilterBetweenOperations(builder),
            ];
            foreach (IQueryParameter operation in operations)
            {
                builder = operation.Compile(request?.Query?.Filter ?? string.Empty);
            }

            IQueryable<UserDto> result = builder
                .Build()
                .Select(r => r.ToDto());

            return Task.FromResult(result);
        }
    }
}
