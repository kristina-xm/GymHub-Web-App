namespace GymHub.Services.Data.Interfaces
{
    using GymHub.Data.Models;
    using GymHub.Web.ViewModels.IndividualTraining;
    using System;
    using System.Threading.Tasks;
    public interface IIndividualTrainingService
    {
        Task CreateTraining(BookIndividualTrainingViewModel model, Guid trainerId, Guid traineeId);

        Task<IndividualTraining> GetTrainingAsync(IndividualTraining trn);

        Task CreateEnrollement(Guid traineeId, Guid trainingId);

        Task<IndividualTraining?> GetTrainingById(Guid trainingId);

        Task CancelTraining(IndividualTraining training);
    }
}
