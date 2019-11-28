using System;

namespace Tavisca.Applause
{
    public class EmployeeDailyTimesheetReport
    {
        public DateTime Date { get; set; }
        public TimesheetDailySubmissionStatus TimesheetDailySubmissionStatus { get; set; }
    }
}
