using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GymHub.Common.EntityValidationConstants.Trainer;

namespace GymHub.Web.ViewModels.User
{
    public class MoreInfoTrainerViewModel
    {

        [Required]
        [StringLength(BioMaxLength, MinimumLength = BioMinLength, ErrorMessage = "You should introduce yourself to the trainees! Bio should be between {0} and {1} caracters.")]
        public string Bio { get; set; } = null!;

        [Required]
        [Range(ExperienceMin, ExperienceMax)]
        public int Experience { get; set; }

        public TrainerCertificateViewModel? Certificate { get; set; }
    }
}
