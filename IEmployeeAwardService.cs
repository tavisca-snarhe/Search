using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeAwardService
    {
        Task<List<EmployeeAwardDetail>> GetMonthlyAwards(string awardName, int month, int year);
        Task<List<EmployeeAwardDetail>> GetAnnualAwards( int year);
        Task<List<EmployeeAward>> GetAwardsOfAnEmployee(string employeeId);
        Task<EmployeeAward> AddAward(EmployeeAward award);

    }
}
