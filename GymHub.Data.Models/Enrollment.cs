using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Data.Models
{
    public class Enrollment
    {
        public Enrollment()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Trainee))]
        public Guid TraineeId { get; set; }
        public Trainee Trainee { get; set; } = null!;

        [ForeignKey(nameof(IndividualTraining))]
        public Guid TrainingId { get; set; }
        public IndividualTraining IndividualTraining { get; set; } = null!;
    }
}
