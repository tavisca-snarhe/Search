using System.Collections.Generic;

namespace Tavisca.Applause
{
    public class EmployeeTimesheetReport
    {

        public string EmployeeId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Tribe { get; set; }
        public TimesheetMonthlySubmissionStatus TimesheetSubmissionStatus { get; set; }
        public List<EmployeeDailyTimesheetReport> EmployeeDailyTimesheetReports { get; set; }
    }
}