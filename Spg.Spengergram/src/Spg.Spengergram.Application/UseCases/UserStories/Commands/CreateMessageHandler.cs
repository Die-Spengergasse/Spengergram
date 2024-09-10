using MediatR;
using Spg.Spengergram.DomainModel.Exceptions.Service;
using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.Application.UseCases.UserStories.Commands
{
    public class CreateMessageHandler : IRequestHandler<CreateMessageModel>
    {
        private readonly IWritableMessageRepository _messageRepository;
        private readonly IReadOnlyMessangerRepository _messangerRepository;

        public CreateMessageHandler(
            IWritableMessageRepository messageRepository, 
            IReadOnlyMessangerRepository messangerRepository)
        {
            _messageRepository = messageRepository;
            _messangerRepository = messangerRepository;
        }

        public Task Handle(CreateMessageModel request, CancellationToken cancellationToken)
        {
            // Init
            Messenger messanger = _messangerRepository.GetByGuid<Messenger>(request.Command.Messanger)
                ?? throw ReadServiceException.FromNotFound();
            
            // Validation
            // TODO: Implement "verifier"

            // Act
            Message newMessage = new Message(request.Command.Body, messanger);

            // Save
            _messageRepository.Create(newMessage);

            // Done
            return Task.CompletedTask;
        }
    }
}
