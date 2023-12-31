﻿namespace GymHub.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static GymHub.Common.EntityValidationConstants.GroupActivity;
    public class GroupActivity
    {
        public GroupActivity()
        {
            this.Id = Guid.NewGuid();
            this.GroupSchedules = new HashSet<GroupSchedule>();
            this.GroupActivityTrainers = new HashSet<GroupActivityTrainer>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required] 
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public ActivityCategory Category { get; set; } = null!;

        [Required]
        public int CountOfMaxSpots { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public ICollection<GroupSchedule> GroupSchedules { get; set; }

        [Required]
        public ICollection<GroupActivityTrainer> GroupActivityTrainers { get; set; }
    }
}
