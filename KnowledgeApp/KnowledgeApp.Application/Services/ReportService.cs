using KnowledgeApp.DataAccess.Repositories;
using KnowledgeApp.Core.Models;

namespace KnowledgeApp.Application.Services
{
    public class ReportService
    {
        private readonly ReportRepository _reportRepository;

        public ReportService(ReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public async Task<List<ReportModel>> GetAll()
        {
            List<ReportModel> reports = await _reportRepository.GetAllReports();
            return reports;
        }

        public async Task<ReportModel> GetReportById(int reportId)
        {
            ReportModel report = await _reportRepository.GetReportById(reportId);
            return report;
        }

        public async Task<ReportModel> CreateReport(ReportModel reportModel)
        {
            ReportModel createdReportId = await _reportRepository.CreateReport(reportModel);
            return createdReportId;
        }

        public async Task<ReportModel> UpdateReport(ReportModel reportModel)
        {
            ReportModel updatedReportModel = await _reportRepository.UpdateReport(reportModel);
            return updatedReportModel;
        }

        public async Task<bool> DeleteReport(int reportId)
        {
            bool result = await _reportRepository.DeleteReport(reportId);
            return result;
        }
    }
}