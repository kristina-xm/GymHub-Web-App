﻿namespace GymHub.Web.ViewModels.Trainer
{
    public class TraineeGroupScheduleViewModel
    {
        public Guid ActivityId { get; set; }
        public Guid EnrollmentId { get; set; }
        public string ActivityName { get; set; } = null!;
        public string TrainerName { get; set; } = null!;
        public DateTime ActivityDay { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }
    }
}
