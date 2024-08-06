using MediatR;
using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.Application.UseCases.UserStories.Queries
{
    public class GetMessageHandler : IRequestHandler<GetMessageModel, IQueryable<MessageDto>>
    {
        private readonly IReadOnlyMessageRepository _messageRepository;

        public GetMessageHandler(IReadOnlyMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public Task<IQueryable<MessageDto>> Handle(GetMessageModel request, CancellationToken cancellationToken)
        {
            IQueryable<MessageDto> result = 
                
            _messageRepository
                .GetByMessanger(request.Query.MessengerId)
                .Select(r => r.ToDto());

            return Task.FromResult(result);
        }
    }
}
