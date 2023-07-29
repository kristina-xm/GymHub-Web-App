using GymHub.Data;
using GymHub.Services.Data.Interfaces;
using GymHub.Web.ViewModels.GroupActivity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Services.Data
{
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
                .Select(ga => new AllActivitiesViewModel()
                { 
                    Id = ga.Id,
                    Name = ga.Name,
                    Intensity = ga.Category.Intensity,
                    TraineeLevel = ga.Category.TraineeLevel,
                    CountOfMaxSpots = ga.CountOfMaxSpots,
                    Description = ga.Description,
                })
                .ToArrayAsync();

            return allActivities;
        }
    }
}
