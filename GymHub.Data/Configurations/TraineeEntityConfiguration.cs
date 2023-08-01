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
    public class TraineeEntityConfiguration : IEntityTypeConfiguration<Trainee>
    {
        public void Configure(EntityTypeBuilder<Trainee> builder)
        {
            builder.HasData(this.GenerateTrainees());
        }

        private Trainee[] GenerateTrainees()
        {
            ICollection<Trainee> trainees = new HashSet<Trainee>();

            Trainee trainee;

            trainee = new Trainee()
            {
                //Yana
                Id = Guid.Parse("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"),
                UserId = Guid.Parse("9F76FB38-94D6-4BA8-9069-FD078CA22EBF"),
                Age = 25,
                Weight = 55,
                Height = 1.74,
                Level = "Intermediate"

            };

            trainees.Add(trainee);

            trainee = new Trainee()
            {
                //James
                Id = Guid.Parse("b6830fbd-a3e8-4465-a596-04565c4568bc"),
                UserId = Guid.Parse("DBC5C34E-0E90-42C9-83DB-9421948F8F44"),
                Age = 30,
                Weight = 89,
                Height = 1.85,
                Level = "Advanced"

            };

            trainees.Add(trainee);

            trainee = new Trainee()
            {
                //Noah
                Id = Guid.Parse("02f24448-29e7-48d1-ae7e-54282df6cc53"),
                UserId = Guid.Parse("557C75B3-D089-46A0-9B71-C800AA685010"),
                Age = 27,
                Height = 1.90,
                Weight = 95,
                Level = "Advanced"

            };
            
            trainees.Add(trainee);

            trainee = new Trainee()
            {
                //Amelie
                Id = Guid.Parse("5546a97c-3ed4-48b7-90c7-2c0d70159e28"),
                UserId = Guid.Parse("AEBA13BB-2B27-4B1B-B702-5FD482830491"),
                Age = 36,
                Weight = null,
                Height = 1.67,
                Level = "Beginner"

            };

            trainees.Add(trainee);

            trainee = new Trainee()
            {
                //Ivan
                Id = Guid.Parse("44ea1e99-19e1-4d88-80f7-3d13cad88c5c"),
                UserId = Guid.Parse("3A0C980B-98FE-4E88-A95E-8926DD775C68"),
                Age = 20,
                Weight = null,
                Height = null,
                Level = "Beginner"
            };

            trainees.Add(trainee);

            trainee = new Trainee()
            {
                //Olivia
                Id = Guid.Parse("10d01292-4c4a-46b3-a1d7-e87212c0a87b"),
                UserId = Guid.Parse("EA4BB973-7977-455A-A92D-6A2CB1DFCCA3"),
                Age = 38,
                Weight = 62,
                Height = 1.70,
                Level = "Intermediate"

            };

            trainees.Add(trainee);

            return trainees.ToArray();
        }
    }
}
