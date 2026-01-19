using Core.Entities;
using Core.Interfaces;
using Dapper;
using Infraestructure.Persistance.Dapper;
using Infraestructure.Persistance.StoredProcedures;
using System.Data;

namespace Infraestructure.Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(User user)
        {
            using var connection = _context.CreateConnection();

            var parameters = new DynamicParameters();
            parameters.Add("p_name", user.Name);
            parameters.Add("p_phone", user.Phone);
            parameters.Add("p_address", user.Address);
            parameters.Add("p_municipality_id", user.MunicipalityId);

            await connection.ExecuteAsync(
                UserStoredProcedures.CreateUser,
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }

        public async Task<List<User>> GetAllAsync()
        {
            using var connection = _context.CreateConnection();

            var users = await connection.QueryAsync<User>(
                $"SELECT * FROM {UserStoredProcedures.GetUsers}()"
            );

            return users.ToList();
        }
    }
}
