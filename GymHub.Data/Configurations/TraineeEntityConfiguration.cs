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
            
        }

        //private Trainee[] GenerateTrainees()
        //{
        //    ICollection<Trainee> trainees = new HashSet<Trainee>();

        //    Trainee trainee;

        //    trainee = new Trainee() 
        //    { 
        //        Id = Guid.Parse(""),
        //        UserId = Guid.
            
        //    };

        //}
    }
}
