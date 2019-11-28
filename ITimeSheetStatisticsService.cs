using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface ITimeSheetStatisticsService
    {
        Task<TimesheetStatistics> GetTimeSheetStatisticsAsync();
    }
}
