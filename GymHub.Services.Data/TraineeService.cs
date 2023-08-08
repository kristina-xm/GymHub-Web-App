using GymHub.Data;
using GymHub.Data.Models;
using GymHub.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymHub.Data.Models;

namespace GymHub.Services.Data
{
    public class TraineeService : ITraineeService
    {
        private readonly GymHubDbContext dbContext;
        public TraineeService(GymHubDbContext context)
        {
            this.dbContext = context;
        }

        public bool CheckTraineeHasTrainingWithTrainer(Trainee trainee, Guid TrainerId)
        {
           var traineeWithEnrollments = this.dbContext.Trainees
              .Include(t => t.Enrollments)
              .ThenInclude(e => e.IndividualTraining)
              .FirstOrDefault(t => t.Id == trainee.Id);

            var trainingsByTrainer = this.dbContext
              .IndividualTrainingsTrainers
              .Where(trainer => trainer.TrainerId == TrainerId)
              .Select(trainer => trainer.IndividualTraining)
              .ToList();


            bool hasEnrollmentWithTrainer = traineeWithEnrollments.Enrollments
                .Any(enrollment => trainingsByTrainer.Any(training => enrollment.IndividualTraining.Id == training.Id));

            //var enrollment = this.dbContext
            //    .Enrollments
            //    .Where(e => e.TraineeId == trainee.Id)
            //    .FirstOrDefault();

         
            //bool hasEnrollmentWithTrainer = trainee.Enrollments
            //    .Any(enrollment => trainingsByTrainer.Any(training => enrollment.IndividualTraining.Id == training.Id));


            return hasEnrollmentWithTrainer;
        }
    }
}
