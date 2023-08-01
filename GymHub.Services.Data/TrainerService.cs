namespace GymHub.Services.Data
{
    using GymHub.Data;
    using GymHub.Data.Models;
    using GymHub.Services.Data.Interfaces;
    using GymHub.ViewModels;
    using GymHub.Web.ViewModels.Trainer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class TrainerService : ITrainerService
    {
        private readonly GymHubDbContext dbContext;
        public TrainerService(GymHubDbContext context)
        {
            this.dbContext = context;
        }

        public async Task<IEnumerable<AllTrainerViewModel>> AllTrainers()
        {
            IEnumerable<AllTrainerViewModel> allTrainers = await dbContext.Trainers
                .Include(t => t.User)
                .Select(t => new AllTrainerViewModel()
                {
                    //ID as Trainer
                    Id = t.Id,
                    FirstName = t.User.FirstName,
                    LastName = t.User.LastName,
                    PhoneNumber = t.User.PhoneNumber,
                    Bio = t.Bio,
                    YearsOfExperience = t.Experience
                })
                .ToArrayAsync();

            return allTrainers;
        }

        public async Task<TrainerDetailsViewModel> GetTrainerByIdAsync(Guid id)
        {
            Trainer trainer = await this.dbContext.Trainers
                .Include(t => t.User)
                .FirstOrDefaultAsync(t => t.Id == id);


            var trainerModel = await this.dbContext.Trainers
                 .Where(t => t.Id == trainer.Id)
                 .Select(t => new TrainerDetailsViewModel
                 {
                     Id = t.Id,
                     FirstName = t.User.FirstName,
                     LastName = t.User.LastName,
                     PhoneNumber = t.User.PhoneNumber,
                     Experience = t.Experience,
                     Bio = t.Bio,
                     DailySchedules = t.IndividualTrainingTrainer.Select(itt => new TrainerDailyScheduleViewModel
                     {
                         StartTime = itt.IndividualTraining.StartTime,
                         EndTime = itt.IndividualTraining.EndTime
                     }).OrderBy(d => d.StartTime)
                     .ToArray()

                 })
                 .FirstOrDefaultAsync();

            var dailyGroupSchedules = this.dbContext.Trainers
                 .Where(t => t.Id == trainer.Id)
                .SelectMany(t => t.GroupActivityTrainers)
                .Include(t => t.GroupActivity)
                .ThenInclude(t => t.GroupSchedules)
                .SelectMany(t => t.GroupActivity.GroupSchedules)
                .Select(gs => new TrainerGroupScheduleViewModel
                {
                    ActivityName = gs.GroupActivity.Name,
                    StartTime = gs.StartTime,
                    EndTime = gs.EndTime
                })
                .ToArray();

            trainerModel.DailyGroupSchedules = dailyGroupSchedules;

            return trainerModel;
        }
    }
}
