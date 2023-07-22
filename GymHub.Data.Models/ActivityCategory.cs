namespace GymHub.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static GymHub.Common.EntityValidationConstants.ActivityCategory;

    public class ActivityCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(IntensityMaxLength)]
        public string Intensity { get; set; } = null!;

        [Required]
        [MaxLength(TraineeLevelMaxLenght)]
        public string TraineeLevel { get; set; } = null!;

    }
}
