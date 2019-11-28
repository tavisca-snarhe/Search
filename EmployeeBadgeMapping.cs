namespace Tavisca.Applause
{
    public class EmployeeBadgeMapping
    {
        public EmployeeBadgeMapping(Employee employee , EmployeeBadge badge)
        {
            Employee = employee;
            EmployeeBadge = badge;
        }
        public Employee Employee { get; set; }
        public EmployeeBadge EmployeeBadge { get; set; }
    }
}
