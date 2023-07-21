namespace GymHub.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class GroupEnrollment
    {
        public GroupEnrollment()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Trainee))]
        public Guid TraineeId { get; set; }
        public Trainee Trainee { get; set; } = null!;

        [ForeignKey(nameof(Schedule))]
        public Guid ScheduleId { get; set; }
        public GroupSchedule Schedule { get; set; } = null!;


    }

}
