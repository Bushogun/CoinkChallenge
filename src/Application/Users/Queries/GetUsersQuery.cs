using Application.Users.Dtos;
using Core.Dtos.ResponsesDto;
using MediatR;

namespace Application.Users.Queries
{
    public class GetUsersQuery: IRequest<Result<List<UserResponseDto>>>;
}
