using KnowledgeApp.DataAccess.Repositories;
using KnowledgeApp.Core.Models;

namespace KnowledgeApp.Application.Services
{
    public class DepartmentService
    {
        private readonly DepartmentRepository _departmentRepository;

        public DepartmentService(DepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<int> CreateDepartmentAsync(DepartmentModel departmentModel)
        {
            int createdDepartmentId = await _departmentRepository.CreateDepartment(departmentModel);

            return createdDepartmentId;
        }
    }
}
