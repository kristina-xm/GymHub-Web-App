using GymHub.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymHub.Data.Configurations;

namespace GymHub.Data.Configurations
{
    public class TrainerEntityConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasData(this.GenerateTrainers());
            builder.HasData(this.SeedAdminTrainer());
        }
        
        private Trainer SeedAdminTrainer()
        {
            Trainer adminTrainer = new Trainer()
            {
                Id = Guid.Parse("3fcaa2a4-59e1-4af4-9146-6f30716f836c"),
                UserId = Guid.Parse("ba3a5230-8e32-4d72-bc27-def1a8ab665a"),
                Bio = "General trainer in this gym",
                Experience = 8
            };

            return adminTrainer;

        }
        private Trainer[] GenerateTrainers()
        {
            ICollection<Trainer> trainers = new HashSet<Trainer>();

            Trainer trainer;

            trainer = new Trainer()
            {
                //Remy
                Id = Guid.Parse("7b785253-5315-49fe-9d0c-39a8935c6902"),
                UserId = Guid.Parse("5F28263D-A630-4364-8267-75307568014F"),
                Bio = "Hello! I'm Remy Leroy, your energetic gym trainer. Passionate about helping clients reach fitness goals, I'll guide you with knowledge and motivation. Let's transform lives, one rep at a time!",
                Experience = 5
            };

            trainers.Add(trainer);

            trainer = new Trainer()
            {
                //Alexander
                Id = Guid.Parse("d1079610-d657-4cea-bf9b-0fc1053a6ee8"),
                UserId = Guid.Parse("BCD3CB31-DC3A-4C20-AD5F-79324BB62443"),
                Bio = "Hey there! I'm Alexander, your dedicated fitness coach. With a mission to inspire a healthier lifestyle, I craft personalized workout routines and nutrition plans. Let's conquer challenges and unleash your potential!",
                Experience = 2
            };

            trainers.Add(trainer);

            trainer = new Trainer()
            {
                //Sophia
                Id = Guid.Parse("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc"),
                UserId = Guid.Parse("0FA5EB44-0F0B-455C-BC32-ED60A57F875E"),
                Bio = "Hi, I'm Sophia, your dynamic gym trainer. Passionate about guiding clients to a healthy life, I'll create personalized workout plans. From strength training to cardio, I'll motivate you to push boundaries. Let's achieve fitness goals together!",
                Experience = 4
            };

            trainers.Add(trainer);

            return trainers.ToArray();

        }

        
    }
}
