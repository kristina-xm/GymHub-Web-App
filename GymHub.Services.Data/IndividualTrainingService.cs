namespace GymHub.Services.Data
{
    using GymHub.Data;
    using GymHub.Data.Models;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.IndividualTraining;
    using Microsoft.EntityFrameworkCore;

    public class IndividualTrainingService : IIndividualTrainingService
    {
        private readonly GymHubDbContext dbContext;
        private readonly IUserService userService;
        public IndividualTrainingService(GymHubDbContext context, IUserService userService)
        {
            this.dbContext = context;
            this.userService = userService;
        }

        public async Task CancelTraining(IndividualTraining training)
        {
            training.IsCanceled = true;

            await this.dbContext.SaveChangesAsync();    
        }

        public async Task<IndividualTraining?> GetTrainingById(Guid trainingId)
        {
            var training = this.dbContext.IndividualTrainings.FirstOrDefault(t => t.Id == trainingId);

            return training;
        }
        public async Task CreateTraining(BookIndividualTrainingViewModel model, Guid trainerId, Guid traineeId)
        {
            IndividualTraining newTraining = new IndividualTraining()
            {
                StartTime = model.Day.Date + model.Start.TimeOfDay,
                EndTime = model.Day.Date + model.End.TimeOfDay,
                Intensity = model.Intensity,
                IsCanceled = false
            };

            await this.dbContext.IndividualTrainings.AddAsync(newTraining);

            
            var trainer = await this.dbContext.Trainers.FirstOrDefaultAsync(t => t.Id == trainerId);

            var training = await GetTrainingAsync(newTraining);

            await CreateEnrollement(traineeId, training.Id);

            IndividualTrainingTrainer relation = new IndividualTrainingTrainer()
            {
                TrainerId = trainer.Id,
                TrainingId = training.Id,
            };

            await this.dbContext.IndividualTrainingsTrainers.AddAsync(relation);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IndividualTraining> GetTrainingAsync(IndividualTraining trn)
        {
            var training = await this.dbContext.IndividualTrainings.FindAsync(trn.Id);

            return training;
        }

       
        public async Task CreateEnrollement(Guid traineeId, Guid trainingId)
        {
            var trainee = await this.userService.GetTraineeAsync(traineeId);


            Enrollment enrollement = new Enrollment()
            {
                Trainee = trainee!,
                TrainingId = trainingId
            };

            await this.dbContext.Enrollments.AddAsync(enrollement);

        }
    }
}
