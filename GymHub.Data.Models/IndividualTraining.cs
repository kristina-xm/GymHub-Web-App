namespace GymHub.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class IndividualTraining
    {

        public IndividualTraining()
        {
            this.IndividualTrainingTrainer = new HashSet<IndividualTrainingTrainer>();
            this.Enrollments = new HashSet<Enrollment>();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public bool isApproved { get; set; } = false;

        public ICollection<IndividualTrainingTrainer> IndividualTrainingTrainer { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }

}