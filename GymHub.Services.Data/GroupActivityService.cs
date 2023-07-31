namespace GymHub.Services.Data
{
    using GymHub.Data;
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
            var activity = await this.dbContext.GroupActivities
                        .Include(ga => ga.GroupActivityTrainers)
                        .ThenInclude(gat => gat.Trainer)
                        .FirstOrDefaultAsync(ga => ga.Id == id);

            var activityModel = await this.dbContext.GroupActivities
                 .Include(c => c.Category)
                 .Include(ga => ga.GroupActivityTrainers)
                    .ThenInclude(gat => gat.Trainer)
                 .Where(ga => ga.Id == id)
                 .Select(ga => new ActivityDetailsViewModel
                 {
                     Id = activity.Id,
                     TrainerId = ga.GroupActivityTrainers.Select(t => t.TrainerId).FirstOrDefault(),
                     ActivityName = ga.Name,
                     TrainerName = string.Join(" ", ga.GroupActivityTrainers.Select(t => t.Trainer.User.FirstName + " " + t.Trainer.User.LastName)),
                     Intensity = ga.Category.Intensity,
                     TraineeLevel = ga.Category.TraineeLevel,
                     Description = ga.Description

                 }).FirstOrDefaultAsync();

            return activityModel;
        }
    }
}
