using Application.Municipalities.Dtos;
using Core.Dtos.ResponsesDto;
using MediatR;

namespace Application.Municipality.Queries
{
    public class GetMunicipalityQuery: IRequest<Result<List<MunicipalityResponseDto>>>;
}
