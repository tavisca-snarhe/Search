using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Applause
{
    public class EmployeeAward:Award
    {
        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string EmployeeAwardDescription { get; set; }
    }
}