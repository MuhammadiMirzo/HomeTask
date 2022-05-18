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

    public List<Department> GetDepartments()
    {
        using(_connection)
        {
            var sql = "select d.id as Id, d.name as Name, e.id as ManagerId, concat(e.firstname,' ', e.lastname  ) as ManagerFullName from department d join employee  e on d.id = e.id";

            var res = _connection.Query<Department>(sql);
            return res.ToList(); 
        }
    }
     
     public int InsertDepartment(UIDepartment department)
     {
         using(_connection)
         {
             var sql = $"insert into department (name) values ('{department.Name}')";
             var res = _connection.Execute(sql);
             return res; 
         }
     }

    public int UpdateDepartment(UIDepartment department, int Id)
     {
         using (_connection)
         {
            var sql = $"update  department set name = '{department.Name}' where id = {Id}"; 
            var res = _connection.Execute(sql);
            return res;
         }
     }


    public int GetDepartmentById(int Id)
     {
         using (_connection)
         {
            var sql = $"select * from department where id = {Id}"; 
            var res = _connection.QuerySingle<Department>(sql);
            return res;
         }
     }

    

}
