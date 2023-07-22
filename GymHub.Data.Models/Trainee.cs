namespace GymHub.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static GymHub.Common.EntityValidationConstants.Trainee;

    public class Trainee
    {
        public Trainee()
        {
            this.Id = Guid.NewGuid();
            this.Enrollments = new HashSet<Enrollment>();
            this.GroupEnrollments = new HashSet<GroupEnrollment>();
        }
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        public double? Weight { get; set; }

        public double? Height { get; set; }

        public string? Gender { get; set; } 

        [Required]
        [MaxLength(LevelMaxLength)]
        public string Level { get; set; } = null!;
        
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<GroupEnrollment> GroupEnrollments { get; set; }
    }
}
