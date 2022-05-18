using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
namespace Api.Controllers;


[ApiController]
[Route("Api/[controller]")]

public class DepartmentController : ControllerBase
{
    private DepartmentService _service;
    public DepartmentController(DepartmentService service)
    {
        _service = service;
    }
    [HttpGet("GetDepartments")]
    public List<Department> GetDepartments()
    {
        return _service.GetDepartments();
    }

    [HttpPost("InsertDepartment")]
    public int InsertDepartment(UIDepartment department)
     {     
          return _service.InsertDepartment(department);
     }
     [HttpPut("UpdateDepartment")]
    public int UpdateDepartment(UIDepartment department,int id)
     {     
          return _service.UpdateDepartment(department,id);
     }
}
