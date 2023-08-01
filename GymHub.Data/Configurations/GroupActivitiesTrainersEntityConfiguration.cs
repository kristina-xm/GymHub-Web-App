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
    public class GroupActivitiesTrainersEntityConfiguration : IEntityTypeConfiguration<GroupActivityTrainer>
    {
        public void Configure(EntityTypeBuilder<GroupActivityTrainer> builder)
        {
            builder.HasKey(gat => new { gat.TrainerId, gat.ActivityId });

           
            builder.HasOne(gat => gat.GroupActivity)
                   .WithMany(ga => ga.GroupActivityTrainers)
                   .HasForeignKey(gat => gat.ActivityId);

            
            builder.HasOne(gat => gat.Trainer)
                   .WithMany(t => t.GroupActivityTrainers)
                   .HasForeignKey(gat => gat.TrainerId);

            builder.HasData(this.GenerateActivityTrainer());
        }

        private GroupActivityTrainer[] GenerateActivityTrainer()
        {
            ICollection<GroupActivityTrainer> trainersActivities = new HashSet<GroupActivityTrainer>();

            GroupActivityTrainer groupActivityTrainer;

            groupActivityTrainer = new GroupActivityTrainer()
            {
                TrainerId = Guid.Parse("7b785253-5315-49fe-9d0c-39a8935c6902"),
                ActivityId = Guid.Parse("25b00a8d-13b9-4c33-a145-96b89264d699"),
            };
            
            trainersActivities.Add(groupActivityTrainer);


            groupActivityTrainer = new GroupActivityTrainer()
            {
                TrainerId = Guid.Parse("d1079610-d657-4cea-bf9b-0fc1053a6ee8"),
                ActivityId = Guid.Parse("6d6ee926-6fa3-43a7-8bac-dc86632094a5"),
            };

            trainersActivities.Add(groupActivityTrainer);

            groupActivityTrainer = new GroupActivityTrainer()
            {
                TrainerId = Guid.Parse("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc"),
                ActivityId = Guid.Parse("436818ef-d86c-4e43-88ca-29ff34ad5850"),
            };

            trainersActivities.Add(groupActivityTrainer);

            return trainersActivities.ToArray();
        }
    }
}
