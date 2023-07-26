namespace GymHub.Services.Data.Interfaces
{
    using GymHub.Web.ViewModels.Trainer;
    public interface ITrainerService
    {
        Task<IEnumerable<AllTrainerViewModel>> AllTrainers();

        Task<TrainerDetailsViewModel> GetTrainerByIdAsync(Guid id);
    }
}
