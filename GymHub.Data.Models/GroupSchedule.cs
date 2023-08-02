namespace GymHub.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class GroupSchedule
    {
        public GroupSchedule()
        { 
            this.Id = Guid.NewGuid();
            this.GroupEnrollments = new HashSet<GroupEnrollment>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime StartTime { get; set; }
                
        [Required]
        public DateTime EndTime { get; set; }

        [ForeignKey(nameof(GroupActivity))]
        public Guid ActivityId { get; set; }

        public int CountOfTrainees { get; set; }

        public GroupActivity GroupActivity { get; set; } = null!;

        public ICollection<GroupEnrollment> GroupEnrollments { get; set; }
    }
}
