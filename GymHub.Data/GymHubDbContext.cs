﻿namespace GymHub.Data
{
    using GymHub.Data.Configurations;
    using GymHub.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection.Emit;

    public class GymHubDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        private ApplicationUser AdminUser { get; set; }
        private Trainer AdminTrainer { get; set; }

        public GymHubDbContext(DbContextOptions<GymHubDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Trainee> Trainees { get; set; } = null!;
        public DbSet<Trainer> Trainers { get; set; } = null!;
        public DbSet<Enrollment> Enrollments { get; set; } = null!;
        public DbSet<IndividualTraining> IndividualTrainings { get; set; } = null!;
        public DbSet<IndividualTrainingTrainer> IndividualTrainingsTrainers { get; set; } = null!;
        public DbSet<GroupEnrollment> GroupEnrollments { get; set; } = null!;
        public DbSet<GroupSchedule> GroupSchedules { get; set; } = null!;
        public DbSet<GroupActivityTrainer> GroupActivityTrainers { get; set; } = null!;
        public DbSet<ActivityCategory> ActivitiesCategories { get; set; } = null!;
        public DbSet<GroupActivity> GroupActivities { get; set; } = null!;
        public DbSet<Certification> Certifications { get; set; } = null!; 
        public DbSet<TrainerCertification> TrainerCertifications { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<IndividualTrainingTrainer>().HasKey(itt => new
            {
                itt.TrainerId,
                itt.TrainingId
            });


            builder.Entity<TrainerCertification>().HasKey(tc => new
            {
                tc.CertificationId,
                tc.TrainerId
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

            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
            builder.ApplyConfiguration(new TraineeEntityConfiguration());
            builder.ApplyConfiguration(new TrainerEntityConfiguration());
            builder.ApplyConfiguration(new CategoryEntityConfiguration());
            builder.ApplyConfiguration(new GroupActivityEntityConfiguration());
            builder.ApplyConfiguration(new GroupSchedulesEntityConfiguration());
            builder.ApplyConfiguration(new GroupActivitiesTrainersEntityConfiguration());
            builder.ApplyConfiguration(new GroupEnrollmentsEntityConfiguration());
            builder.ApplyConfiguration(new IndividualTrainingEntityConfiguration());
            builder.ApplyConfiguration(new IndividualTrainingTrainerEntityConfiguration());
            builder.ApplyConfiguration(new EnrollmentEntityConfiguration());
            builder.ApplyConfiguration(new CertificationEntityConfiguration());
            builder.ApplyConfiguration(new CertificationTrainerEntityConfiguration());

        }
    }
}