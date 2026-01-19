using Application.Municipalities.Dtos;
using MediatR;
using Core.Dtos.ResponsesDto;
using Microsoft.AspNetCore.Mvc;
using Application.Municipality.Commands.GetMunicipality;
using Application.Municipality.Queries;

namespace API.Controllers
{
    [ApiController]
    [Route("api/Municipality")]
    public class MunicipalityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MunicipalityController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET api/Municipality
        [HttpGet]
        public async Task<Result<List<MunicipalityResponseDto>>> GetMunicipality()
        {
            return await _mediator.Send(new GetMunicipalityQuery());
        }

    }
}
