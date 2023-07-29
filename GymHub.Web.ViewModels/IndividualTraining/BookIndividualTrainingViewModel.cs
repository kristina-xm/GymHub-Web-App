using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Web.ViewModels.IndividualTraining
{
    public class BookIndividualTrainingViewModel
    {
        public Guid TrainerId { get; set; }

        [Required]
        public DateTime Day { get; set; } = DateTime.Today;

        [Required]
        public DateTime Start { get; set; } = DateTime.Now;

        [Required]
        public DateTime End { get; set; } = DateTime.Now.AddHours(1);
        public bool isCanceled { get; set; } = false;
    }
}
