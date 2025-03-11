using Microsoft.AspNetCore.Mvc;
using KnowledgeApp.Application.Services;
using KnowledgeApp.API.Contracts;
using KnowledgeApp.Core.Models;

namespace KnowledgeApp.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentService _departmentService;
        public DepartmentController(DepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpPost]
        public async Task<IResult> CreateDepartment(DepartmentRequest departmentRequest)
        {
            try
            {
                var newDepartmentModel = new DepartmentModel(departmentRequest.Name, departmentRequest.FacultyId);
                int newDepartmentId = await _departmentService.CreateDepartmentAsync(newDepartmentModel);
                return Results.Json(newDepartmentId);

            } catch(Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        [HttpGet]
        public IResult Get()
        {
            return Results.Ok();
        }
    }
}
