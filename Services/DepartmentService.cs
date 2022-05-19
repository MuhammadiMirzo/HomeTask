namespace Services;
using Npgsql;
using Dapper;
using Domain;

public class DepartmentService
{
    private string connectionString = "Server=127.0.0.1;Port=5432;Database=Compony;User Id=postgres;Password=1234;";

    private NpgsqlConnection  _connection;
    public DepartmentService()
    {
        _connection = new NpgsqlConnection(connectionString);
        
    }

    public async Task<List<Department>> GetDepartments()
    {
        using(_connection)
        {
            var sql = "select d.id as Id, d.name as Name, e.id as ManagerId, concat(e.firstname,' ', e.lastname  ) as ManagerFullName from department d join employee  e on d.id = e.id";

            var res =await _connection.QueryAsync<Department>(sql);
            return res.ToList(); 
        }
    }
     
     public async Task<int> InsertDepartment(UIDepartment department)
     {
         using(_connection)
         {
             var sql = $"insert into department (name) values ('{department.Name}')";
             var res =await _connection.ExecuteAsync(sql);
             return res; 
         }
     }

    public async Task<int> UpdateDepartment(UIDepartment department, int Id)
     {
         using (_connection)
         {
            var sql = $"update  department set name = '{department.Name}' where id = {Id}"; 
            var res =  await _connection.ExecuteAsync(sql);
            return res;
         }
     }


    public async Task <Department> GetDepartmentById(int Id)
     {
         using (_connection)
         {
            var sql = $"select * from department where id = {Id}"; 
            var res =await _connection.QuerySingleAsync<Department>(sql);
            return res;
         }
     }
}
