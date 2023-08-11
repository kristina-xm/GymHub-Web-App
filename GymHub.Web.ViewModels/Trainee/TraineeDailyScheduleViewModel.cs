namespace GymHub.ViewModels
{
    public class TraineeDailyScheduleViewModel
    {
        public Guid TrainingId { get; set; }
        public string Name { get; set; } = "Individual training";
        public string TrainerName { get; set; } = null!;
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}