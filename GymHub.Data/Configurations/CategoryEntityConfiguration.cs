using GymHub.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymHub.Data.Configurations
{
    internal class CategoryEntityConfiguration : IEntityTypeConfiguration<ActivityCategory>
    {
        public void Configure(EntityTypeBuilder<ActivityCategory> builder)
        {
            builder.HasData(this.GenerateCategories());
        }

        private ActivityCategory[] GenerateCategories()
        {
            ICollection<ActivityCategory> categories = new HashSet<ActivityCategory>();

            ActivityCategory category;

            category = new ActivityCategory()
            {
                Id = 1,
                Intensity = "Low",
                TraineeLevel = "Beginner"
            };

            categories.Add(category);

            //Begginers do not have high intensive trainings
            category = new ActivityCategory()
            {
                Id =2, 
                Intensity = "Moderate",
                TraineeLevel = "Beginner"
            };

            categories.Add(category);

            //Intermediate and Advanced trainees can join Moderate and High intensive trainings
            category = new ActivityCategory()
            {
                Id = 3,
                Intensity = "Moderate",
                TraineeLevel = "Intermediate"
            };

            categories.Add(category);

            category = new ActivityCategory()
            {
                Id = 4,
                Intensity = "Moderate",
                TraineeLevel = "Advanced"
            };

            categories.Add(category);

            category = new ActivityCategory()
            {
                Id = 5,
                Intensity = "High",
                TraineeLevel = "Intermediate"
            };

            categories.Add(category);

            category = new ActivityCategory()
            {
                Id = 6,
                Intensity = "High",
                TraineeLevel = "Advanced"
            };

            categories.Add(category);

            return categories.ToArray();
        }
    }
}
