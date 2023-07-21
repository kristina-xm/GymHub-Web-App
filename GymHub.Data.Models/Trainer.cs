namespace GymHub.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static GymHub.Common.EntityValidationConstants.Trainer;
    public class Trainer
    {
        public Trainer()
        {
            this.Id = Guid.NewGuid();
            this.IndividualTrainingTrainer = new HashSet<IndividualTrainingTrainer>();
            this.GroupActivitiesTrainers = new HashSet<GroupActivityTrainer>();
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;

        [Required]
        [MaxLength(BioMaxLength)]
        public string Bio { get; set; } = null!;

        [Required]
        public int Experience { get; set; }


        public int CountOfTrainees { get; set; }

        public ICollection<IndividualTrainingTrainer> IndividualTrainingTrainer { get; set; }
        public ICollection<GroupActivityTrainer> GroupActivitiesTrainers { get; set; }
    }
}
