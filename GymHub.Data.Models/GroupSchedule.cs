namespace GymHub.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class GroupSchedule
    {
        public GroupSchedule()
        {
            //this.Activities = new HashSet<GroupActivity>();
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime Day { get; set; }

        [Required]
        public DateTime StartHour { get; set; }

        [Required]
        public DateTime EndHour { get; set; }

        [ForeignKey(nameof(GroupActivity))]
        public Guid ActivityId { get; set; }

        public GroupActivity GroupActivity { get; set; } = null!;

        //public ICollection<GroupActivity> Activities { get; set; }
    }
}
