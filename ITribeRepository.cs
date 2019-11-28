using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface ITribeRepository
    {
        Task<string> AddTribe(string tribe);
        Task<List<string>> GetAllTribes();
        Task<bool> DeleteTribe(string tribe);
        Task<string> UpdateTribe(string tribe);
    }
}
