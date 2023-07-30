namespace GymHub.Data.Configurations
{
    using GymHub.Data.Models;
    using GymHub.Data.Configurations;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class GroupActivityEntityConfiguration : IEntityTypeConfiguration<GroupActivity>
    {
        public void Configure(EntityTypeBuilder<GroupActivity> builder)
        {
            builder.HasData(this.GenerateGroupActivities());
        }

        private GroupActivity[] GenerateGroupActivities()
        {
            ICollection<GroupActivity> groupActivities = new HashSet<GroupActivity>();

            GroupActivity groupActivity;

            groupActivity = new GroupActivity()
            {
                Id = Guid.Parse("0bb32c51-d799-4004-915f-91ccea62ce11"),
                Name = "Cross Training",
                CategoryId = 6,
                CountOfMaxSpots = 20,
                Description = "Cross training is a diverse workout approach that involves mixing various exercises and activities to enhance overall fitness and prevent workout plateaus. By combining cardio, strength training, and flexibility exercises, it targets multiple muscle groups and reduces the risk of overuse injuries."
                
            };

            groupActivities.Add(groupActivity);

            groupActivity = new GroupActivity()
            {
                Id = Guid.Parse("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"),
                Name = "Kickboxing",
                CategoryId = 3,
                CountOfMaxSpots = 20,
                Description = "Kickboxing is a high-intensity martial art and cardio workout that combines punching, kicking, and knee strikes. It improves overall fitness, endurance, and self-defense skills while providing a fun and challenging way to burn calories and relieve stress.",
               
            };

            groupActivities.Add(groupActivity);

            return groupActivities.ToArray();
        }

       
    }
}
