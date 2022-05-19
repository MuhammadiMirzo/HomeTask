using Npgsql;
using Domain;
using Dapper;

namespace Services;

public class ManagerService
{
    private string connectionString = "Server=127.0.0.1;Port=5432;Database=Compony;User Id=postgres;Password=1234;";
   
    private NpgsqlConnection? _connection;

    public ManagerService()
    {
        _connection = new NpgsqlConnection(connectionString);
    }

    public async Task<List<GetManagers>> GetManagers()
    {
        using (_connection)
        {
            var sql = $"select "
        }
    }


}
