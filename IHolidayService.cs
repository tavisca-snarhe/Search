using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IHolidayService
    {
        Task<List<Holiday>> AddHolidays(Stream holidaysFileStream);
    }
}