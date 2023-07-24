using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Web.ViewModels.User
{
    public class RegisteredTraineeViewModel
    {
        public int Age { get; set; }
       
        public double? Weight { get; set; }
       
        public double? Height { get; set; }

        public string? Gender { get; set; }

        public string Level { get; set; } = null!;
    }
}
