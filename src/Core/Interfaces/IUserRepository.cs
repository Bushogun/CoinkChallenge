using Core.Entities;

namespace Core.Interfaces
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
    }
}
