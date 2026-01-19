using Application.Users.Dtos;
using Core.Dtos.ResponsesDto;
using Core.Interfaces;
using MediatR;

namespace Application.Users.Queries
{
    public class GetUsersHandler
        : IRequestHandler<GetUsersQuery, Result<List<UserResponseDto>>>
    {
        private readonly IUserRepository _repository;

        public GetUsersHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<List<UserResponseDto>>> Handle(
            GetUsersQuery request,
            CancellationToken cancellationToken
        )
        {
            var users = await _repository.GetAllAsync();

            var response = users.Select(u => new UserResponseDto
            {
                IdUser = u.Id.ToString(),
                Name = u.Name,
                Phone = u.Phone,
                Address = u.Address,
                MunicipalityId = u.MunicipalityId
            }).ToList();

            return Result<List<UserResponseDto>>.Success(response);
        }
    }
}
