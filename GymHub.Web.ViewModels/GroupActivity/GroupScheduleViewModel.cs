using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Web.ViewModels.GroupActivity
{
    public class GroupScheduleViewModel
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; } 

        public DateTime StartHour { get; set; }

        public DateTime EndHour { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public int RemainingSpots { get; set; }

    }
}
