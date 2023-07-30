namespace GymHub.Web.ViewModels.GroupActivity
{
    public class AllActivitiesViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;
        public string TrainerName { get; set; } = null!;

        public string Intensity { get; set; } = null!;
        public string TraineeLevel { get; set; } = null!;

        public int CountOfMaxSpots { get; set; }


        public string Description = null!;
    }
}
