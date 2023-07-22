namespace GymHub.Web.ViewModels.User
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using static GymHub.Common.EntityValidationConstants.Trainee;
    public class MoreInfoTraineeViewModel
    {
        [Required]
        [Range(AgeMin, AgeMax, ErrorMessage = "Age should be between {0} and {1}")]
        public int Age { get; set; }

        [Range(WeightMin, WeightMax, ErrorMessage = "Weight should be between {0} and {1}")]
        public double? Weight { get; set; }

        [Range(HeightMin, HeightMax, ErrorMessage = "Height should be between {0} and {1}")]
        public double? Height { get; set; }

        public string? Gender { get; set; }

        [Required]
        public string Level { get; set; } = null!;
    }
}
