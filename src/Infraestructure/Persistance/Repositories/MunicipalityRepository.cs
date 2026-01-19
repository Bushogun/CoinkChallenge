using Core.Entities;
using Core.Interfaces;
using Dapper;
using Infraestructure.Persistance.Dapper;
using Infraestructure.Persistance.StoredProcedures;
using System.Data;

namespace Infraestructure.Persistance.Repositories
{
    public class MunicipalityRepository : IMunicipalityRepository
    {
        private readonly DapperContext _context;

        public MunicipalityRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<List<Municipality>> GetAllAsync()
        {
            using var connection = _context.CreateConnection();

            var municipalities = await connection.QueryAsync<Municipality>(
                $"SELECT * FROM {MunicipalityStoredProcedures.GetMunicipalities}()",
                commandType: CommandType.Text
            );

            return municipalities.ToList();
        }
    }
}
