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
            this.GroupActivityTrainers = new HashSet<GroupActivityTrainer>();
            this.TrainerCertifications = new HashSet<TrainerCertification>();
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [MaxLength(BioMaxLength)]
        public string Bio { get; set; } = null!;

        [Required]
        public int Experience { get; set; }

        [Required]
        public int CountOfTrainees { get; set; }

        public ICollection<IndividualTrainingTrainer> IndividualTrainingTrainer { get; set; }
        public ICollection<GroupActivityTrainer> GroupActivityTrainers { get; set; }
        public ICollection<TrainerCertification> TrainerCertifications { get; set; }
    }
}
