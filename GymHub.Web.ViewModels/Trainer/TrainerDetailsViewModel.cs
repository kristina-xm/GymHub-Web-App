namespace GymHub.Web.ViewModels.Trainer
{
    using GymHub.ViewModels;
    using GymHub.Web.ViewModels.User;
    using System;
    using System.Collections.Generic;
    public class TrainerDetailsViewModel
    {
        
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;
        
        public int Experience { get; set; }

        public string Bio { get; set; } = null!;

        public TrainerScheduleViewModel TrainerSchedule { get; set; }

        public TrainerCertificateViewModel Certificate { get; set; }
    }
}
