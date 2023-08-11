using GymHub.Data.Models;
using GymHub.Web.ViewModels.Trainee;
using GymHub.Web.ViewModels.Trainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Services.Data.Interfaces
{
    public interface ITraineeService
    {
        bool CheckTraineeHasTrainingWithTrainer(Trainee trainee, Guid TrainerId);

        Task<MyUpcomingTrainingsViewModel> GetAllUpcomingTrainings(Guid userId);
    }
}
