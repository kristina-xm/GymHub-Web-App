namespace GymHub.Services.Data.Interfaces
{
    using GymHub.Data.Models;
    using GymHub.Web.ViewModels.User;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    

    public interface IUserService
    {
        Task AddTraineeUser(MoreInfoTraineeViewModel model, Guid userId);

        Task AddTrainerUser(MoreInfoTrainerViewModel model, Guid userId);

        Task<bool> CheckUserTypeExistance(Guid userId);

        Task<Trainer?> GetTrainerAsync(Guid userId);
        Task<Trainee?> GetTraineeAsync(Guid userId);

        Task<object> GetTrainerTypeInfoForEdit(Trainer trainer);
        Task<object> GetTraineeTypeInfoForEdit(Trainee trainee);

        Task EditTraineeAsync(RegisteredTraineeViewModel traineeModel, Guid userId);
        Task EditTrainerAsync(RegisteredTrainerViewModel trainerModel, Guid userId);

    }
}
