﻿namespace GymHub.Web.ViewModels.GroupActivity
{
    public class ActivityDetailsViewModel
    {
        public ActivityDetailsViewModel()
        {
            this.Schedules = new HashSet<GroupScheduleViewModel>();
        }
        public Guid Id { get; set; }
        public Guid TrainerId { get; set; }
        public string ActivityName { get; set; } = null!;
        public string TrainerName { get; set; } = null!;
        public string Intensity { get; set; } = null!;
        public string TraineeLevel { get; set; } = null!;

        public string Description { get; set; } = null!;

        public ICollection<GroupScheduleViewModel> Schedules { get; set; }
    }
}
