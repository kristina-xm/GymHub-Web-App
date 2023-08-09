using GymHub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Web.ViewModels.Trainer
{
    public class TrainerScheduleViewModel
    {
        public TrainerScheduleViewModel()
        {
            this.DailySchedules = new HashSet<TrainerDailyScheduleViewModel>();
            this.DailyGroupSchedules = new HashSet<TrainerGroupScheduleViewModel>();
        }
        public ICollection<TrainerDailyScheduleViewModel> DailySchedules { get; set; }
        public ICollection<TrainerGroupScheduleViewModel> DailyGroupSchedules { get; set; }
    }
}
