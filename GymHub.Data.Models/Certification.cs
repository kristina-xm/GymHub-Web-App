namespace GymHub.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static GymHub.Common.EntityValidationConstants.Certification;
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
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public DateTime IssueDate { get; set; }

        [Required]
        public ICollection<TrainerCertification> TrainersCertifications { get; set; } 
    }
}
