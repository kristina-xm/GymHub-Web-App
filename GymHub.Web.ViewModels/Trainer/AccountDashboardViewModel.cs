using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Web.ViewModels.Trainer
{
    public class AccountDashboardViewModel
    {
        public int UpcomingIndividualTrainings { get; set; }

        public int CountOfManagedGroupActivities { get; set; }

        public int UpcomingGroupTrainings { get; set; }
    }
}
