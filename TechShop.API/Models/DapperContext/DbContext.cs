using Microsoft.Data.SqlClient;
using System.Data;

namespace TechShop.API.Models.DapperContext
{
    public class DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string? _connectionString;

        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _connectionString = _configuration.GetConnectionString("connection");

            if (_connectionString == null)
            {
                throw new InvalidOperationException("Connection string 'connection' not found.");
            }
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
