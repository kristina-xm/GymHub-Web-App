using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymHub.Data.Models
{
    public class GroupActivityTrainer
    {

        [ForeignKey(nameof(Trainer))]
        public Guid TrainerId { get; set; }
        public Trainer Trainer { get; set; } = null!;
        
        [ForeignKey(nameof(GroupActivity))]
        public Guid ActivityId { get; set; }
        public GroupActivity GroupActivity { get; set; } = null!;
    }
}
