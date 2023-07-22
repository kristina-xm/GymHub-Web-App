namespace GymHub.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Certification
    {
        public Certification()
        {
            this.Id = Guid.NewGuid();
            this.TrainersCertifications = new HashSet<TrainerCertification>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public DateTime IssueDate { get; set; }

        public ICollection<TrainerCertification> TrainersCertifications { get; set; } 
    }
}
