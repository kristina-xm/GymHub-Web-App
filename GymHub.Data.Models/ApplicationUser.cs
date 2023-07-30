namespace GymHub.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel.DataAnnotations;
    using static GymHub.Common.EntityValidationConstants.User;

    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        [MaxLength(NameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]
        public string LastName { get; set; } = null!;


    }
}
