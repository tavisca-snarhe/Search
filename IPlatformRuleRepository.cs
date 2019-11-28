using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IPlatformRuleRepository
    {
        Task<List<PlatformRule>> GetAllPlatformRules();   
    }
}