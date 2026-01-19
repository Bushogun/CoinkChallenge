using Application.Users.Commands;
using Application.Users.Dtos;
using Application.Users.Queries;
using Core.Dtos.ResponsesDto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET api/users
        [HttpGet]
        [Consumes("application/json")]
        public async Task<Result<List<UserResponseDto>>> GetUsers()
        {
            return await _mediator.Send(new GetUsersQuery());
        }
        // POST api/users
        [HttpPost]
        [Consumes("application/json")]
        public async Task<Result<CreateUserResponseDto>> PostUser([FromBody] CreateUserCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}
