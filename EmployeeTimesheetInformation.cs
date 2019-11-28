using System;

namespace Tavisca.Applause
{
    public class EmployeeTimesheetInformation
    {
        public EmployeeTimesheetInformation() { }
        public EmployeeTimesheetInformation (string employeeId, string userName, string tribe, string squad, TimesheetDailySubmissionStatus timesheetDailySubmissionStatus, TimesheetMonthlySubmissionStatus monthlySubmissionStatus, DateTime date)
        {
            EmployeeId = employeeId;
            UserName = userName;
            Tribe = tribe;
            Squad = squad;
            TimesheetSubmissionStatus = monthlySubmissionStatus;
            Date = date;
            TimesheetDailySubmissionStatus = timesheetDailySubmissionStatus;
        }
        public string EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Tribe { get; set; }
        public string Squad { get; set; }
        public TimesheetMonthlySubmissionStatus TimesheetSubmissionStatus { get; set; }
        public DateTime Date { get; set; }
        public TimesheetDailySubmissionStatus TimesheetDailySubmissionStatus { get; set; }  
    }
}