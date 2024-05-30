using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Spg.Spengergram.Application.UseCases.UserStories.Commands;
using Spg.Spengergram.Application.UseCases.UserStories.Queries;
using Spg.Spengergram.DomainModel.Commands;
using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Exceptions.Service;
using Spg.Spengergram.DomainModel.Queries;

namespace Spg.Spengergram.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //                  -property- -operation- -value-
        // api/users?filter=lastname    ct         asd
        [HttpGet()]
        [Authorize(Roles = "admin")]
        public IActionResult Get([FromQuery()] GetUserFilteredQuery query)
        {
            List<UserDto> data = _mediator
                .Send(new GetUserFilteredModel(query))
                .Result
                .ToList();
            return Ok(data);
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateProfile(UpdateProfileCommand command)
        {
            try
            {
                _mediator.Send(new UpdateProfileModel(command));
                return NoContent();
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (WriteServiceException)
            {
                return StatusCode(500);
            }
        }
    }
}
