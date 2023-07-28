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
                TrainerId = Guid.Parse("AD716331-39A9-4EF2-88F2-0E69F7654EC1"),
                TrainingId = Guid.Parse("63d1f1d6-9348-4710-8082-20a1fbf189e2"),
            };

            trainingTrainers.Add(trainingTrainer);

            trainingTrainer = new IndividualTrainingTrainer()
            {
                TrainerId = Guid.Parse("AD716331-39A9-4EF2-88F2-0E69F7654EC1"),
                TrainingId = Guid.Parse("3e154226-2820-4837-81c8-247e4604cdd6"),
            };

            trainingTrainers.Add(trainingTrainer);

            trainingTrainer = new IndividualTrainingTrainer()
            {
                TrainerId = Guid.Parse("E4C6589B-AFA8-49C0-8D78-119D3EE95269"),
                TrainingId = Guid.Parse("66afc146-91e8-461f-a9c2-8b61419f6af3"),
            };

            trainingTrainers.Add(trainingTrainer);

            trainingTrainer = new IndividualTrainingTrainer()
            {
                TrainerId = Guid.Parse("0D61D878-2B3D-49BD-B4FB-AC482A7D9BDA"),
                TrainingId = Guid.Parse("a2b6df44-832f-4ae2-ae77-4f8bc89a66af"),
            };

            trainingTrainers.Add(trainingTrainer);

            trainingTrainer = new IndividualTrainingTrainer()
            {
                TrainerId = Guid.Parse("0D61D878-2B3D-49BD-B4FB-AC482A7D9BDA"),
                TrainingId = Guid.Parse("492b5886-64cf-4f0e-9fdb-2baed606e361"),
            };

            trainingTrainers.Add(trainingTrainer);

            return trainingTrainers.ToArray();
        }
    }
}
