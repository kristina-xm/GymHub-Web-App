namespace GymHub.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class IndividualTrainingTrainer
    {
        [ForeignKey(nameof(Trainer))]
        public Guid TrainerId { get; set; }

        public Trainer Trainer { get; set; } = null!;


        [ForeignKey(nameof(IndividualTraining))]
        public Guid TrainingId { get; set; }

        public IndividualTraining IndividualTraining { get; set; } = null!;

    }
}
