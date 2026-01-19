using Application.Municipalities.Dtos;
using Application.Municipality.Queries;
using Core.Dtos.ResponsesDto;
using Core.Interfaces;
using MediatR;

namespace Application.Municipality.Commands.GetMunicipality
{
    public class GetMunicipalityHandler
        : IRequestHandler<GetMunicipalityQuery, Result<List<MunicipalityResponseDto>>>
    {
        private readonly IMunicipalityRepository _repository;

        public GetMunicipalityHandler(IMunicipalityRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<List<MunicipalityResponseDto>>> Handle(
            GetMunicipalityQuery request,
            CancellationToken cancellationToken
        )
        {
            var municipalities = await _repository.GetAllAsync();

            if (municipalities == null || !municipalities.Any())
            {
                return Result<List<MunicipalityResponseDto>>.Failure(
                    "No municipalities found"
                );
            }

            var response = municipalities.Select(m => new MunicipalityResponseDto
            {
                Id = m.Id,
                Name = m.Name,
                CountryId = m.DepartmentId
            }).ToList();

            return Result<List<MunicipalityResponseDto>>.Success(response, response.Count);
        }
    }
}
