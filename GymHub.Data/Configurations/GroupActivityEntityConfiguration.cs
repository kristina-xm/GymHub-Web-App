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
            builder.HasMany(ga => ga.GroupActivityTrainers)
              .WithOne(gat => gat.GroupActivity)
              .HasForeignKey(gat => gat.ActivityId);

            builder.HasData(this.GenerateGroupActivities());
        }

        public GroupActivity[] GenerateGroupActivities()
        {
            ICollection<GroupActivity> groupActivities = new HashSet<GroupActivity>();

            GroupActivity groupActivity;

            groupActivity = new GroupActivity()
            {
                Id = Guid.Parse("25b00a8d-13b9-4c33-a145-96b89264d699"),
                Name = "Cross Training",
                CategoryId = 6,
                CountOfMaxSpots = 15,
                Description = "Cross training is a diverse workout approach that involves mixing various exercises and activities to enhance overall fitness and prevent workout plateaus. By combining cardio, strength training, and flexibility exercises, it targets multiple muscle groups and reduces the risk of overuse injuries."
              
            };

            groupActivities.Add(groupActivity);

            groupActivity = new GroupActivity()
            {
                Id = Guid.Parse("6d6ee926-6fa3-43a7-8bac-dc86632094a5"),
                Name = "Kickboxing",
                CategoryId = 3,
                CountOfMaxSpots = 10,
                Description = "Kickboxing is a high-intensity martial art and cardio workout that combines punching, kicking, and knee strikes. It improves overall fitness, endurance, and self-defense skills while providing a fun and challenging way to burn calories and relieve stress."

            };

            groupActivities.Add(groupActivity);

            groupActivity = new GroupActivity()
            {
                Id = Guid.Parse("436818ef-d86c-4e43-88ca-29ff34ad5850"),
                Name = "Yoga",
                CategoryId = 1,
                CountOfMaxSpots = 25,
                Description = "Yoga is a holistic practice that unites mind, body, and spirit. It incorporates physical postures, breathing techniques, and meditation to promote flexibility, strength, and inner peace. Embracing yoga can reduce stress and foster overall well-being. Connect with yourself and experience the transformative power of yoga."

            };

            groupActivities.Add(groupActivity);

            return groupActivities.ToArray();
        }

       
    }
}
