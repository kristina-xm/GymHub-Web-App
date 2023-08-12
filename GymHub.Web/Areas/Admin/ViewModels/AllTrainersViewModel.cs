namespace GymHub.Web.Areas.Admin.ViewModels
{
    public class AllTrainersViewModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Experience { get; set; } 
        public string? ActivityName { get; set; }
    }
}
