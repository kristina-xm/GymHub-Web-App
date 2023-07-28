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
            builder.HasData(this.GenerateActivityTrainer());
        }

        private GroupActivityTrainer[] GenerateActivityTrainer()
        {
            ICollection<GroupActivityTrainer> trainersActivities = new HashSet<GroupActivityTrainer>();

            GroupActivityTrainer groupActivityTrainer;

            groupActivityTrainer = new GroupActivityTrainer()
            {
                TrainerId = Guid.Parse("AD716331-39A9-4EF2-88F2-0E69F7654EC1"),
                ActivityId= Guid.Parse("0bb32c51-d799-4004-915f-91ccea62ce11"),
            };
            
            trainersActivities.Add(groupActivityTrainer);


            groupActivityTrainer = new GroupActivityTrainer()
            {
                TrainerId = Guid.Parse("5B86293B-856F-47B8-8B93-63A3C7A965E1"),
                ActivityId = Guid.Parse("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"),
            };

            trainersActivities.Add(groupActivityTrainer);

            return trainersActivities.ToArray();
        }
    }
}
