using KnowledgeApp.DataAccess.Context;
using KnowledgeApp.DataAccess.Entities;
using KnowledgeApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace KnowledgeApp.DataAccess.Repositories
{
    public class ReportRepository
    {
        private readonly KnowledgeTestDbContext _context;

        public ReportRepository(KnowledgeTestDbContext context)
        {
            _context = context;
        }

        public async Task<ReportModel> CreateReport(ReportModel reportModel)
        {
            var discipline = await _context.Disciplines.SingleOrDefaultAsync(d => d.Id == reportModel.DisciplineId);
            if (discipline == null) throw new Exception("Дисциплины с таким id не существует");

            
        }
    }
}