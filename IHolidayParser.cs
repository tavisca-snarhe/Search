using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IHolidayParser
    {
        List<Holiday> Parse(DataTable holidayDetails);
    }
}