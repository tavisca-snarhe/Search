using System;
using System.Collections.Generic;

namespace Tavisca.Applause
{
    public class TimesheetStatistics
    {
        public List<TimesheetDailyTribeWiseStatistics> DailyTribeWiseStatistics { get; set; }
        public double PercentageDailyFills { get; set; }
        public double PercentageMonthlySubmissions { get; set; }
        public DateTime Date { get; set; }
    }
}
