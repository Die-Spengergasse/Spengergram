using MediatR;
using Microsoft.AspNetCore.Mvc;
using Spg.Spengergram.Application.UseCases.UserStories.Queries;
using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Queries;

namespace Spg.Spengergram.Api.Controllers
{
    [Route("api/messages")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MessageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //                  -property- -operation- -value-
        // api/users?filter=lastname    ct         asd
        [HttpGet()]
        public IActionResult Get([FromQuery()] GetMessageQuery query)
        {
            List<MessageDto> data = _mediator
                .Send(new GetMessageModel(query))
                .Result
                .ToList();
            return Ok(data);
        }
    }
}
