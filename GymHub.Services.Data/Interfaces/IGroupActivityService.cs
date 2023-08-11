using GymHub.Data.Models;
using GymHub.Web.ViewModels.GroupActivity;
using GymHub.Web.ViewModels.Trainer;
using System.Threading.Tasks;

namespace GymHub.Services.Data.Interfaces
{
    public interface IGroupActivityService
    {
        Task<IEnumerable<AllActivitiesViewModel>> AllActivities();
        Task<ActivityDetailsViewModel> GetActivityModelByIdAsync(Guid activityId);

        Task CreateGroupEnrollement(Trainee trainee, Guid scheduleId);

        Task<GroupEnrollment?> GetEnrollmentById(Guid scheduleId);

        Task CancelEnrollment(GroupEnrollment groupEnrollment);

        Task<bool> CheckIfTraineeEnrolled(Guid scheduleId);
    }
}
