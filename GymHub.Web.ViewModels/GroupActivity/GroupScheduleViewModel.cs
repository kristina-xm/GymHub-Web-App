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

        public string StartHour { get; set; } = null!;

        public string EndHour { get; set; } = null!;

        public int RemainingSpots { get; set; }

    }
}
