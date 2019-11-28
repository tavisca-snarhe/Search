using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IHolidayReader
    {
        Task<DataTable> Read(Stream stream, string tabName);
    }
}