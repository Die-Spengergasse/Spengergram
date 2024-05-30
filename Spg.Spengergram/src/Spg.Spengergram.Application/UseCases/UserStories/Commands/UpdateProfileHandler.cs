using MediatR;
using Spg.Spengergram.DomainModel.Exceptions.Repository;
using Spg.Spengergram.DomainModel.Exceptions.Service;
using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Application.UseCases.UserStories.Commands
{
    public class UpdateProfileHandler : IRequestHandler<UpdateProfileModel>
    {
        private readonly IWritableUserRepository _writableUserRepository;
        private readonly IReadOnlyUserRepository _readOnlyUserRepository;

        public UpdateProfileHandler(
            IWritableUserRepository userRepository, 
            IReadOnlyUserRepository readOnlyUserRepository)
        {
            _writableUserRepository = userRepository;
            _readOnlyUserRepository = readOnlyUserRepository;
        }

        public Task Handle(UpdateProfileModel request, CancellationToken cancellationToken)
        {
            // Init
            User existigUser = _readOnlyUserRepository.GetByGuid<User>(request.Command.Id)
                ?? throw ReadServiceException.FromNotFound();

            // Validation
            // ...

            // Act
            try
            {
                _writableUserRepository
                    .UpdateBuilder
                    .WithEntity(existigUser)
                    .WithFirstName(request.Command.FirstName)
                    .WithLastName(request.Command.LastName)
                    .Save();
            }
            catch (WriteRepositoryException ex)
            {
                throw WriteServiceException.FromUpdate(ex);
            }

            return Task.CompletedTask;
        }
    }
}
