namespace GymHub.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ActivityCategory
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; } = null!;

        public string TraineeLevel { get; set; } = null!;
    }
}
