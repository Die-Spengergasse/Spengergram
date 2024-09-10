using MediatR;
using Spg.Spengergram.DomainModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.Application.UseCases.UserStories.Commands
{
    public class CreateMessageModel : IRequest
    {
        public CreateMessageCommand Command { get; set; }

        public CreateMessageModel(CreateMessageCommand command)
        {
            Command = command;
        }
    }
}
