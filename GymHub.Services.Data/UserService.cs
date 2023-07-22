namespace GymHub.Services.Data
{
    using GymHub.Data;
    using GymHub.Data.Models;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.User;

    public class UserService : IUserService
    {
        private readonly GymHubDbContext dbContext;

        public UserService(GymHubDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddTraineeUser(MoreInfoTraineeViewModel model, Guid userId)
        {
            var trainee = new Trainee
            {
                UserId = userId,
                Age = model.Age,
                Weight = model.Weight,
                Height = model.Height,
                Level = model.Level,
                Gender = model.Gender
            };

            await this.dbContext.Trainees.AddAsync(trainee);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task AddTrainerUser(MoreInfoTrainerViewModel model, Guid userId)
        {
            if (model.Certificate != null)
            {
                var certificate = new Certification
                {
                    Name = model.Certificate.Name,
                    IssueDate = model.Certificate.IssueDate
                };

                var certificateOfTrainer = new TrainerCertification
                {
                    TrainerId = userId,
                    CetrificationId = certificate.Id,
                };

                await this.dbContext.Certifications.AddAsync(certificate);
                await this.dbContext.TrainerCertifications.AddAsync(certificateOfTrainer);
                
            }

            var trainer = new Trainer
            {
                UserId = userId,
                Experience = model.Experience,
                Bio = model.Bio,
                
            };
           
            

            await this.dbContext.Trainers.AddAsync(trainer);
            await this.dbContext.SaveChangesAsync();
        }

    }
}