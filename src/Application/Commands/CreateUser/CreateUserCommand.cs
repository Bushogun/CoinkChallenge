using MediatR;

namespace Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<Unit>
    {
        public string Name { get; init; }
        public string Phone { get; init; }
        public string Address { get; init; }
        public int MunicipalityId { get; init; }
    }

}
