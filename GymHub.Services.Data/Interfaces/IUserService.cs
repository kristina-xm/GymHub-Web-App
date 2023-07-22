namespace GymHub.Services.Data.Interfaces
{
    using GymHub.Web.ViewModels.User;
    using System.Threading.Tasks;

    public interface IUserService
    {
        Task AddTraineeUser(MoreInfoTraineeViewModel model, Guid userId);

        Task AddTrainerUser(MoreInfoTrainerViewModel model, Guid userId);
    }
}
