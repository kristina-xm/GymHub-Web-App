namespace GymHub.Services.Data
{
    using GymHub.Data;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.Trainer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
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
    }
}
