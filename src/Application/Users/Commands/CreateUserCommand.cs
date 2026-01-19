using Application.Users.Dtos;
using Core.Dtos.ResponsesDto;
using MediatR;

namespace Application.Users.Commands
{
    public class CreateUserCommand : UserCreateParamsDto, IRequest<Result<CreateUserResponseDto>>;
}
