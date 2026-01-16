using MediatR;
using Core.Entities;
using Core.Interfaces;

namespace Application.Commands.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, Unit>
    {
        private readonly IUserRepository _repository;

        public CreateUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(request.Name))
                throw new ArgumentException("Name is required");

            var user = new User(
                request.Name,
                request.Phone,
                request.Address,
                request.MunicipalityId
            );

            await _repository.CreateAsync(user);

            return Unit.Value;
        }
    }
}
