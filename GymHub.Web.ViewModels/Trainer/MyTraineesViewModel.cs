namespace GymHub.Web.ViewModels.Trainer
{
    public class MyTraineesViewModel
    {
        public Guid TraineeId { get; set; }

        public Guid TrainingId { get; set; }
        public string TraineeFirstName { get; set; } = null!;

        public string TraineeLastName { get; set; } = null!;

        public string? TraineePhoneNumber { get; set; }

        public DateTime TrainingDate { get; set; }
        public DateTime TrainingStart { get; set; }
        public DateTime TrainingEnd { get; set; }


    }
}
