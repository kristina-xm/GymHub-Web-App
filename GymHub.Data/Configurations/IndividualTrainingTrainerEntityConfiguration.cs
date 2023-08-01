using GymHub.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Data.Configurations
{
    public class IndividualTrainingTrainerEntityConfiguration : IEntityTypeConfiguration<IndividualTrainingTrainer>
    {
        public void Configure(EntityTypeBuilder<IndividualTrainingTrainer> builder)
        {
            builder.HasData(this.GenerateTrainingTrainer());
        }

        private IndividualTrainingTrainer[] GenerateTrainingTrainer()
        {
            ICollection<IndividualTrainingTrainer> trainingTrainers = new HashSet<IndividualTrainingTrainer>();

            IndividualTrainingTrainer trainingTrainer;

            trainingTrainer = new IndividualTrainingTrainer()
            {
                TrainerId = Guid.Parse("7b785253-5315-49fe-9d0c-39a8935c6902"),
                TrainingId = Guid.Parse("88034cb7-c971-4520-a3a1-d48099502562"),
            };

            trainingTrainers.Add(trainingTrainer);

            trainingTrainer = new IndividualTrainingTrainer()
            {
                TrainerId = Guid.Parse("7b785253-5315-49fe-9d0c-39a8935c6902"),
                TrainingId = Guid.Parse("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca"),
            };

            trainingTrainers.Add(trainingTrainer);

            trainingTrainer = new IndividualTrainingTrainer()
            {
                TrainerId = Guid.Parse("d1079610-d657-4cea-bf9b-0fc1053a6ee8"),
                TrainingId = Guid.Parse("5bd931f9-f5ca-472c-8c81-9f011118c0e5"),
            };

            trainingTrainers.Add(trainingTrainer);

            trainingTrainer = new IndividualTrainingTrainer()
            {
                TrainerId = Guid.Parse("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc"),
                TrainingId = Guid.Parse("82a1b1c7-1b12-4973-a8c0-9720fe4255fc"),
            };

            trainingTrainers.Add(trainingTrainer);

            trainingTrainer = new IndividualTrainingTrainer()
            {
                TrainerId = Guid.Parse("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc"),
                TrainingId = Guid.Parse("922bf694-a4e1-4fbe-b508-8cbfa836600f"),
            };

            trainingTrainers.Add(trainingTrainer);

            return trainingTrainers.ToArray();
        }
    }
}
