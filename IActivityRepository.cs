using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IActivityRepository
    {
        Task<List<Activity>> GetAllActivitiesByPlatform(string platform);
        Task<List<Activity>> GetAllActivities();
        Task<Activity> GetActivityByName(string name);
        Task<Activity> UpdateActivity(Activity activity);
        Task<Activity> AddActivity(Activity activity);
    }
}
