using GymHub.Web.ViewModels.GroupActivity;

namespace GymHub.Services.Data.Interfaces
{
    public interface IGroupActivityService
    {
        Task<IEnumerable<AllActivitiesViewModel>> AllActivities();
    }
}
