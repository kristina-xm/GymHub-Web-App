namespace GymHub.Web.ViewModels.Trainer
{
    using GymHub.ViewModels;
    using GymHub.Web.ViewModels.User;
    using System;
    using System.Collections.Generic;
    public class TrainerDetailsViewModel
    {
        public TrainerDetailsViewModel()
        {
            this.DailySchedules = new HashSet<TrainerDailyScheduleViewModel>();
            this.DailyGroupSchedules = new HashSet<TrainerGroupScheduleViewModel>();
          
        }
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;
        
        public int Experience { get; set; }

        public string Bio { get; set; } = null!;

        public ICollection<TrainerDailyScheduleViewModel> DailySchedules { get; set; }
        public ICollection<TrainerGroupScheduleViewModel> DailyGroupSchedules { get; set; }
        public TrainerCertificateViewModel Certificate { get; set; }
    }
}
