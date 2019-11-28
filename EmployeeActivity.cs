using System;

namespace Tavisca.Applause
{
    public class EmployeeActivity
    {
        public string EmployeeId { get; set; }
        public DateTime DateTime { get; set; }
        public string Details { get; set; } //specific model of activity
        public Activity Activity { get; set; }
    }
}
