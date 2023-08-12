namespace GymHub.Web.Areas.Admin.ViewModels
{
    public class AllTraineesViewModel
    {
        public string TraineeFirstName { get; set; } = null!;

        public string TraineeLastName { get; set; } = null!;

        public string? TraineePhoneNumber { get; set; }
        public string Email { get; set; } = null!;

        public string TraineeLevel { get; set; } = null!;

        public int TraineeAge { get; set; }
    }
}
