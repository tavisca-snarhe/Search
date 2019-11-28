using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeAwardsRepository
    {
        Task<EmployeeAward> AddAward(EmployeeAward award);
        Task<List<EmployeeAward>> GetAwardsByEmployeeId(string employeeId);
        Task<List<EmployeeAward>> GetMonthlyAwards(string awardName, int year, int month);
        Task<List<EmployeeAward>> GetAnnualAwards(int year);
    }
}