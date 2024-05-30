using MediatR;
using Spg.Spengergram.DomainModel.Commands;

namespace Spg.Spengergram.Application.UseCases.UserStories.Commands
{
    public class UpdateProfileModel : IRequest
    {
        public UpdateProfileCommand Command { get; set; }

        public UpdateProfileModel(UpdateProfileCommand command)
        {
            Command = command;
        }
    }
}
