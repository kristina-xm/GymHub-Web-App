using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Data.Models
{
    public class TrainerCertification
    {
        [ForeignKey(nameof(Certification))]
        public Guid CetrificationId { get; set; }
        public Certification Certification { get; set; } = null!;


        [ForeignKey(nameof(Trainer))]
        public Guid TrainerId { get; set; }
        public Trainer Trainer { get; set; } = null!;
    }
}
