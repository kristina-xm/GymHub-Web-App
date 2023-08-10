namespace GymHub.Services.Data.Interfaces
{
    using GymHub.ViewModels;
    using GymHub.Web.ViewModels.Trainer;
    public interface ITrainerService
    {
        Task<IEnumerable<AllTrainerViewModel>> AllTrainers();

        Task<TrainerDetailsViewModel> GetTrainerWithScheduleByIdAsync(Guid id);

        Task<AccountDashboardViewModel> GetDashboardData(Guid trainerId);

        Task<ICollection<TrainerDailyScheduleViewModel>> GetIndividualTrainingsSchedule(Guid trainerId);

        Task<ICollection<TrainerGroupScheduleViewModel>> GetGroupActivitiesSchedule(Guid trainerId);
    }
}
