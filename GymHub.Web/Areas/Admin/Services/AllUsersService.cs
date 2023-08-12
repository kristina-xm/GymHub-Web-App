using GymHub.Data;
using GymHub.Web.Areas.Admin.ViewModels;
using GymHub.Web.Areas.Admin.Services.Interfaces;
using GymHub.Web.ViewModels.Trainer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GymHub.Web.Areas.Admin.Services
{
    public class AllUsersService : IAllUsersService
    {
        private readonly GymHubDbContext dbContext;

        public AllUsersService(GymHubDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ICollection<AllTrainersViewModel>> GetAllUsersTrainers()
        {
            var trainers = await this.dbContext
                .Trainers
                .Include(t => t.User)
                .Include(t => t.GroupActivityTrainers)
                .ThenInclude(t => t.GroupActivity)
                .Select(c => new AllTrainersViewModel
                {
                    FirstName = c.User.FirstName,
                    LastName = c.User.LastName,
                    PhoneNumber = c.User.PhoneNumber,
                    Email = c.User.Email,
                    Experience = c.Experience,
                    ActivityName = c.GroupActivityTrainers.Select(gat => gat.GroupActivity.Name).First()

                }).ToArrayAsync();

            return trainers;
                
        }

        public async Task<ICollection<AllTraineesViewModel>> GetAllUsersTrainees()
        {
            var trainees = await this.dbContext
                .Trainees
                .Include(t => t.User)
                .Select(c => new AllTraineesViewModel
                {
                    TraineeFirstName = c.User.FirstName,
                    TraineeLastName = c.User.LastName,
                    Email = c.User.Email,
                    TraineePhoneNumber = c.User.PhoneNumber,
                    TraineeAge = c.Age

                }).ToArrayAsync();

            return trainees;

        }
    }
}
