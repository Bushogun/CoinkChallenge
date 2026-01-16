using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace Infraestructure.Persistance.Dapper
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration
                ?? throw new ArgumentNullException(nameof(configuration));

            _connectionString = _configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string not found");
        }

        public IDbConnection CreateConnection()
            => new NpgsqlConnection(_connectionString);
    }
}
