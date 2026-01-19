using MediatR;
using Core.Entities;
using Core.Interfaces;
using Core.Dtos.ResponsesDto;
using Application.Users.Dtos;

namespace Application.Users.Commands
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, Result<CreateUserResponseDto>>
    {
        private readonly IUserRepository _repository;

        public CreateUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<CreateUserResponseDto>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                return Result<CreateUserResponseDto>.Failure(
                    "Name is required"
                );
            }

            if (string.IsNullOrWhiteSpace(request.Phone))
            {
                return Result<CreateUserResponseDto>.Failure(
                    "Phone is required"
                );
            }

            var user = new User(
                request.Name,
                request.Phone,
                request.Address,
                request.MunicipalityId
            );

            await _repository.CreateAsync(user);

            var response = new CreateUserResponseDto
            {
                IdUser = user.Id.ToString(),
                Status = "CREATED"
            };

            return Result<CreateUserResponseDto>.Success(response);
        }
    }
}
