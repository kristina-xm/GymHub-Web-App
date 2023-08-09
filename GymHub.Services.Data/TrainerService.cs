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
    using GymHub.Web.ViewModels.User;
    public class TrainerService : ITrainerService
    {
        private readonly GymHubDbContext dbContext;
        public TrainerService(GymHubDbContext context)
        {
            this.dbContext = context;
        }

        public async Task<AccountDashboardViewModel> GetDashboardData(Guid userId)
        {
            //var trainer = this.dbContext.Trainers.Where(t => t.User.Id == userId).FirstOrDefault();

            var model = new AccountDashboardViewModel();

            var upcomingIndividualTrainingsCount = dbContext.Trainers
             .Where(t => t.User.Id == userId)
             .SelectMany(t => t.IndividualTrainingTrainer)
             .SelectMany(itt => itt.IndividualTraining.Enrollments)
             .Count(enrollment => enrollment.IndividualTraining.StartTime > DateTime.UtcNow);

            var groupActivityCount = dbContext.Trainers
                .Include(t => t.GroupActivityTrainers)
                .Where(t => t.UserId == userId)
                .Count();

            var upcomingGroupActivities = dbContext.Trainers
                .Where(t => t.UserId == userId)
                .SelectMany(t => t.GroupActivityTrainers)
                .SelectMany(gat => gat.GroupActivity.GroupSchedules)
                .Count(schedule => schedule.StartTime > DateTime.UtcNow);

            model.UpcomingIndividualTrainings = upcomingIndividualTrainingsCount;
            model.CountOfManagedGroupActivities = groupActivityCount;
            model.UpcomingGroupTrainings = upcomingGroupActivities;
            return model;

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
            Trainer? trainer = await this.dbContext.Trainers
                .Include(t => t.User)
                .FirstOrDefaultAsync(t => t.Id == id);


            var trainerModel = await this.dbContext.Trainers
                 .Where(t => t.Id == trainer.Id)
                 .Include(t => t.TrainerCertifications)
                    .ThenInclude(tc => tc.Certification)
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
                     .ToArray(),
                     Certificate = new TrainerCertificateViewModel 
                     {
                         Name = t.TrainerCertifications.FirstOrDefault()!.Certification.Name,
                         IssueDate = t.TrainerCertifications.FirstOrDefault()!.Certification.IssueDate,
                         IssuingOrganization = t.TrainerCertifications.FirstOrDefault()!.Certification.IssuingOrganization
                     }


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
