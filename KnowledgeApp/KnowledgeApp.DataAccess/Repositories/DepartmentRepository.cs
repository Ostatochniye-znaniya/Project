using KnowledgeApp.DataAccess.Context;
using KnowledgeApp.DataAccess.Entities;
using KnowledgeApp.Core.Models;

namespace KnowledgeApp.DataAccess.Repositories
{
    public class DepartmentRepository
    {
        private readonly KnowledgeTestDbContext _context;

        public DepartmentRepository(KnowledgeTestDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateDepartment(DepartmentModel departmentModel)
        {
            // необходимые проверки 

            var departmentEntity = new Department
            {
                Name = departmentModel.Name,
                FacultyId = departmentModel.FacultyId
            };

            await _context.Departments.AddAsync(departmentEntity);
            await _context.SaveChangesAsync();

            return departmentEntity.Id;

        }

        // метод get

        // метод getAll

        // метод update

        // метод delete
    }
}
