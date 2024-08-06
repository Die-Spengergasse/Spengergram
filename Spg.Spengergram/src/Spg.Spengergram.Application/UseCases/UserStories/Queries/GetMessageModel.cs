using MediatR;
using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.Application.UseCases.UserStories.Queries
{
    public class GetMessageModel : IRequest<IQueryable<MessageDto>>
    {
        public GetMessageQuery Query { get; }

        public GetMessageModel(GetMessageQuery query)
        {
            Query = query;
        }
    }
}
