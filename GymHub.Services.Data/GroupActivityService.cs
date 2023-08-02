namespace GymHub.Services.Data
{
    using GymHub.Data;
    using GymHub.Data.Models;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.GroupActivity;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class GroupActivityService : IGroupActivityService
    {
        private readonly GymHubDbContext dbContext;

        public GroupActivityService(GymHubDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<AllActivitiesViewModel>> AllActivities()
        {

            IEnumerable<AllActivitiesViewModel> allActivities = await dbContext.GroupActivities
                .Include(c => c.Category)
                .Include(gta => gta.GroupActivityTrainers)
                .ThenInclude(t => t.Trainer)
                .ThenInclude(u => u.User)
                .Select(ga => new AllActivitiesViewModel()
                {
                    Id = ga.Id,
                    TrainerId = ga.GroupActivityTrainers.Select(t => t.TrainerId).FirstOrDefault(),
                    Name = ga.Name,
                    TrainerName = string.Join(" ", ga.GroupActivityTrainers.Select(t => t.Trainer.User.FirstName + " " + t.Trainer.User.LastName)),
                    Intensity = ga.Category.Intensity,
                    TraineeLevel = ga.Category.TraineeLevel,
                    CountOfMaxSpots = ga.CountOfMaxSpots,
                    Description = ga.Description,
                })
                .ToArrayAsync();

            return allActivities;
        }

        public async Task<ActivityDetailsViewModel> GetActivityModelByIdAsync(Guid id)
        {
            
            DateTime currentDateTime = DateTime.Now;

            var activityModel = await this.dbContext.GroupActivities
                 .Include(c => c.Category)
                 .Include(ga => ga.GroupActivityTrainers)
                    .ThenInclude(gat => gat.Trainer)
                 .Include(ga => ga.GroupSchedules)
                 .Where(ga => ga.Id == id)
                 .Select(ga => new ActivityDetailsViewModel
                 {
                     Id = ga.Id,
                     TrainerId = ga.GroupActivityTrainers.Select(t => t.TrainerId).FirstOrDefault(),
                     ActivityName = ga.Name,
                     TrainerName = string.Join(" ", ga.GroupActivityTrainers.Select(t => t.Trainer.User.FirstName + " " + t.Trainer.User.LastName)),
                     Intensity = ga.Category.Intensity,
                     TraineeLevel = ga.Category.TraineeLevel,
                     Description = ga.Description,

                     Schedules = ga.GroupSchedules
                     .Where(gs => gs.StartTime >= currentDateTime)
                     .Select(gs => new GroupScheduleViewModel
                     {
                         Id = gs.Id,
                         Date = gs.StartTime.Date,
                         StartHour = gs.StartTime,
                         EndHour = gs.EndTime,
                         DayOfWeek = gs.StartTime.DayOfWeek,
                         RemainingSpots = ga.CountOfMaxSpots - gs.CountOfTrainees

                     })
                     .OrderBy(gs => gs.Date)
                     .ThenBy(gs => gs.StartHour)
                     .ThenBy(gs => gs.EndHour)
                     .ToList()

                 }).FirstOrDefaultAsync();

            return activityModel;
        }

        public async Task CreateGroupEnrollement(Trainee trainee, Guid scheduleId)
        {
            var groupSchedule = await this.dbContext.GroupSchedules.FirstOrDefaultAsync(gs => gs.Id == scheduleId);

            GroupEnrollment groupEnrollement = new GroupEnrollment()
            {
                TraineeId = trainee.Id,
                ScheduleId = scheduleId,
            };

            await this.dbContext.GroupEnrollments.AddAsync(groupEnrollement);
            await this.dbContext.SaveChangesAsync();


            groupSchedule.GroupEnrollments.Add(groupEnrollement);
            groupSchedule.CountOfTrainees++;

            await this.dbContext.SaveChangesAsync();

        }
    }
}
