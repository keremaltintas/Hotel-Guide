using ReportMicroService.DTOs;
using ReportMicroService.Models;

namespace ReportMicroService.Interfaces
{
    public interface IReportService
    {
        List<Report> GetReports();
        Report GetReportById(Guid reportId);
        Task<Report> SaveReportAsync(Report report);
    }
}
