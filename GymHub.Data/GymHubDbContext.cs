namespace GymHub.Data
{
    using GymHub.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection.Emit;

    public class GymHubDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public GymHubDbContext(DbContextOptions<GymHubDbContext> options)
            : base(options)
        {

        }

        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<IndividualTraining> IndividualTrainings { get; set; }
        public DbSet<IndividualTrainingTrainer> IndividualTrainingsTrainers { get; set; }
        public DbSet<GroupEnrollment> GroupEnrollments { get; set; }
        public DbSet<GroupSchedule> GroupSchedules { get; set; }
        public DbSet<GroupActivityTrainer> GroupActivityTrainers { get; set; }
        public DbSet<ActivityCategory> ActivitiesCategories { get; set; }
        public DbSet<GroupActivity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
           .Property(u => u.PhoneNumber)
            .IsRequired();

            builder.Entity<IndividualTrainingTrainer>().HasKey(itt => new
            {
                itt.TrainerId,
                itt.TrainingId
            });

            builder.Entity<GroupActivityTrainer>().HasKey(gat => new
            {
                gat.TrainerId,
                gat.ActivityId
            });

            builder.Entity<Trainer>()
            .HasOne(t => t.User)
            .WithMany()
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Trainee>()
           .HasOne(t => t.User)
           .WithMany()
           .HasForeignKey(t => t.UserId)
           .OnDelete(DeleteBehavior.NoAction);
           
        }
    }
}