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
    public class IndividualTrainingEntityConfiguration : IEntityTypeConfiguration<IndividualTraining>
    {
        public void Configure(EntityTypeBuilder<IndividualTraining> builder)
        {
            builder.HasData(this.GenerateIndividualTrainings());
        }

        private IndividualTraining[] GenerateIndividualTrainings()
        {
            ICollection<IndividualTraining> result = new HashSet<IndividualTraining>();

            IndividualTraining training;

            training = new IndividualTraining()
            {
                Id = Guid.Parse("63d1f1d6-9348-4710-8082-20a1fbf189e2"),
                StartTime = new DateTime(2023, 08, 23, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 23, 13, 0, 0),
                Intensity = "Low",
                IsCanceled = false,
            };

            result.Add(training);
            training = new IndividualTraining()
            {
                Id = Guid.Parse("3e154226-2820-4837-81c8-247e4604cdd6"),
                StartTime = new DateTime(2023, 08, 22, 14, 0, 0),
                EndTime = new DateTime(2023, 08, 22, 15, 0, 0),
                Intensity = "High",
                IsCanceled = false,
            };

            result.Add(training);

            training = new IndividualTraining()
            {
                Id = Guid.Parse("66afc146-91e8-461f-a9c2-8b61419f6af3"),
                StartTime = new DateTime(2023, 08, 15, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 15, 11, 0, 0),
                Intensity = "High",
                IsCanceled = false,
            };

            result.Add(training);

            training = new IndividualTraining()
            {
                Id = Guid.Parse("a2b6df44-832f-4ae2-ae77-4f8bc89a66af"),
                StartTime = new DateTime(2023, 08, 17, 12, 0, 0),
                EndTime = new DateTime(2023, 08, 17, 13, 0, 0),
                Intensity = "Moderate",
                IsCanceled = false,
            };

            result.Add(training);

            training = new IndividualTraining()
            {
                Id = Guid.Parse("492b5886-64cf-4f0e-9fdb-2baed606e361"),
                StartTime = new DateTime(2023, 08, 18, 18, 0, 0),
                EndTime = new DateTime(2023, 08, 18, 19, 30, 0),
                Intensity = "Moderate",
                IsCanceled = false,
            };

            result.Add(training);

            return result.ToArray();
        }
    }
}
