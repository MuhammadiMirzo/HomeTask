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
    public async Task<List<Department>> GetDepartments()
    {
        return await _service.GetDepartments();
    }

    [HttpPost("InsertDepartment")]
    public async Task<int> InsertDepartment(UIDepartment department)
     {     
          return await _service.InsertDepartment(department);
     }
     [HttpPut("UpdateDepartment")]
    public async  Task<int> UpdateDepartment(UIDepartment department,int id)
     {     
          return await _service.UpdateDepartment(department,id);
     }
}
