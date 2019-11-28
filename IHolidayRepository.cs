using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IHolidayRepository
    {
        Task<Holiday> AddHoliday(Holiday holiday);
        Task<List<Holiday>> AddHolidays(List<Holiday> holidays);
        Task<Holiday> UpdateHoliday(Holiday holiday);
        Task<Holiday> GetHoliday(int year, int month, int day);
        Task<List<Holiday>> GetHolidays(int year, int month);
        Task<bool> DeleteHoliday(Holiday holiday);

    }
}
