﻿namespace GymHub.Services.Data
{
    using GymHub.Data;
    using GymHub.Data.Models;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.User;
    using Microsoft.EntityFrameworkCore;

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
            var trainer = new Trainer
            {
                UserId = userId,
                Experience = model.Experience,
                Bio = model.Bio,

            };

            await this.dbContext.Trainers.AddAsync(trainer);
            await this.dbContext.SaveChangesAsync();

            var addedTrainer = await this.dbContext.Trainers.FirstOrDefaultAsync(t => t.UserId == userId);


            if (model.Certificate != null)
            {
                var certificate = new Certification
                {
                    Name = model.Certificate.Name,
                    IssueDate = model.Certificate.IssueDate
                };

                var certificateOfTrainer = new TrainerCertification
                {
                    TrainerId = addedTrainer!.Id,
                    CetrificationId = certificate.Id,
                };

                await this.dbContext.Certifications.AddAsync(certificate);
                await this.dbContext.TrainerCertifications.AddAsync(certificateOfTrainer);

                await this.dbContext.SaveChangesAsync();
            }

        }

        public async Task<bool> CheckUserTypeExistance(Guid userId)
        {
            bool userExists = dbContext.Trainees.Any(t => t.UserId == userId) || dbContext.Trainers.Any(tr => tr.UserId == userId);


            return userExists;

        }

        //public async Task<object?> GetUserType(Guid userId)
        //{
        //    var traineeUser = await dbContext.Trainees.FirstOrDefaultAsync(t => t.UserId == userId);
        //    var trainerUser = await dbContext.Trainers.FirstOrDefaultAsync(t => t.UserId == userId);

        //    if (trainerUser != null)
        //    {
        //        return trainerUser;
        //    }
        //    else
        //    {
        //        return traineeUser;
        //    }

        //}

        public async Task<Trainer?> GetTrainer(Guid userId)
        {

            var trainerUser = await dbContext.Trainers.FirstOrDefaultAsync(t => t.UserId == userId);

            return trainerUser;

        }

        public async Task<Trainee?> GetTrainee(Guid userId)
        {

            var traineeUser = await dbContext.Trainees.FirstOrDefaultAsync(t => t.UserId == userId);

            return traineeUser;

        }

        public async Task<object> GetTraineeTypeInfoForEdit(Trainee trainee)
        {
            //var user = GetUserType(userId);



            return new RegisteredTraineeViewModel()
            {
                Age = trainee.Age,
                Weight = trainee.Weight,
                Height = trainee.Height,
                Gender = trainee.Gender,
                Level = trainee.Level
            };


        }

        public async Task<object> GetTrainerTypeInfoForEdit(Trainer trainer)
        { 

            return new RegisteredTrainerViewModel()
            {
                Bio = trainer.Bio,
                Experience = trainer.Experience

            };



        }
    }
}