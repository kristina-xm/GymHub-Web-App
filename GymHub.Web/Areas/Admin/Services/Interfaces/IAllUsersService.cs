using GymHub.Web.Areas.Admin.ViewModels;

namespace GymHub.Web.Areas.Admin.Services.Interfaces
{
    public interface IAllUsersService
    {
        Task<ICollection<AllTrainersViewModel>> GetAllUsersTrainers();

        Task<ICollection<AllTraineesViewModel>> GetAllUsersTrainees();
    }
}
