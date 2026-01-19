using Core.Entities;

namespace Core.Interfaces
{
    public interface IMunicipalityRepository
    {
        Task<List<Municipality>> GetAllAsync();
    }
}
