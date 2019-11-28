using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface ITimesheetRepository
    {
        Task<EmployeeTimesheetInformation> AddEmployeeTimesheetInformation(EmployeeTimesheetInformation employeeTimesheetInformation);
        Task<List<EmployeeTimesheetInformation>> AddEmployeesTimesheetInformation(List<EmployeeTimesheetInformation> employeeTimesheetInformation);
        Task<EmployeeTimesheetReport> GetMonthlyTimesheetInformation( string employeeId,int year, int month); //Particular employee's report
        Task<EmployeeTimesheetInformation> GetDailyTimesheetInformation(string employeeId, int year, int month, int day);//Employee's Daily Data
        Task<List<EmployeeTimesheetInformation>> GetDailyTimesheetInformation(List<string> employeeIds, int year, int month, int day);// Tribewise Daily Data
        Task<List<EmployeeTimesheetReport>> GetMonthlyTimesheetInformation(List<string> employeeIds, int year, int month);// Tribewise monthly
        Task<EmployeeTimesheetInformation> UpdateRecord(EmployeeTimesheetInformation employeeActivity);
        Task<bool> DeleteRecord(string employeeId);
    }
}