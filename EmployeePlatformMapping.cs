using System.Collections.Generic;

namespace Tavisca.Applause
{
    public class EmployeePlatformMapping
    {
        public string EmpId { get;  set; }

        public List<EmployeePlatformIdentifier> EmployeePlatformIdentifiers = new List<EmployeePlatformIdentifier>();
    }
}
