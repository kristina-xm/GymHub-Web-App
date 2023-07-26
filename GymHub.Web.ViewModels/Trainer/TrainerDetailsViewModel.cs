using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Web.ViewModels.Trainer
{
    public class TrainerDetailsViewModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public int Experience { get; set; }

        public string Bio { get; set; } = null!;
    }
}
