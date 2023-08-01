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
                Id = Guid.Parse("88034cb7-c971-4520-a3a1-d48099502562"),
                StartTime = new DateTime(2023, 08, 23, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 23, 13, 0, 0),
                Intensity = "Low",
                IsCanceled = false,
            };

            result.Add(training);
            training = new IndividualTraining()
            {
                Id = Guid.Parse("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca"),
                StartTime = new DateTime(2023, 08, 22, 14, 0, 0),
                EndTime = new DateTime(2023, 08, 22, 15, 0, 0),
                Intensity = "High",
                IsCanceled = false,
            };

            result.Add(training);

            training = new IndividualTraining()
            {
                Id = Guid.Parse("5bd931f9-f5ca-472c-8c81-9f011118c0e5"),
                StartTime = new DateTime(2023, 08, 15, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 15, 11, 0, 0),
                Intensity = "High",
                IsCanceled = false,
            };

            result.Add(training);

            training = new IndividualTraining()
            {
                Id = Guid.Parse("82a1b1c7-1b12-4973-a8c0-9720fe4255fc"),
                StartTime = new DateTime(2023, 08, 17, 12, 0, 0),
                EndTime = new DateTime(2023, 08, 17, 13, 0, 0),
                Intensity = "Moderate",
                IsCanceled = false,
            };

            result.Add(training);

            training = new IndividualTraining()
            {
                Id = Guid.Parse("922bf694-a4e1-4fbe-b508-8cbfa836600f"),
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
