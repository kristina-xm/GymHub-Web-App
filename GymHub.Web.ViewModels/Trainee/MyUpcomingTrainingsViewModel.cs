using GymHub.ViewModels;
using GymHub.Web.ViewModels.Trainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Web.ViewModels.Trainee
{
    public class MyUpcomingTrainingsViewModel
    {
        public MyUpcomingTrainingsViewModel()
        {
            this.Trainings = new HashSet<TraineeDailyScheduleViewModel>();
            this.Activities = new HashSet<TraineeGroupScheduleViewModel>();
        }
        
        public IEnumerable<TraineeDailyScheduleViewModel> Trainings { get; set; }

        public IEnumerable<TraineeGroupScheduleViewModel> Activities { get; set; }


    }
}
