using GymHub.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Data.Configurations
{
    public class GroupSchedulesEntityConfiguration : IEntityTypeConfiguration<GroupSchedule>
    {
        public void Configure(EntityTypeBuilder<GroupSchedule> builder)
        {
            builder.HasData(this.GenerateCrossTrainingSchedules());
            builder.HasData(this.GenerateKickBoxingSchedules());
            builder.HasData(this.GenerateYogaSchedules());
        }

        private GroupSchedule[] GenerateCrossTrainingSchedules()
        {
            ICollection<GroupSchedule> crossTrainSchedules = new HashSet<GroupSchedule>();

            GroupSchedule crossTrainSchedule;

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("47d1b94a-1e4b-4ae4-986d-60298849b1c7"),
                StartTime = new DateTime(2023, 08, 08, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 08, 17, 30, 0),
                ActivityId = Guid.Parse("25b00a8d-13b9-4c33-a145-96b89264d699")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("ae048160-36c5-4dbb-ba0d-83854fa3f338"),
                StartTime = new DateTime(2023, 08, 22, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 22, 17, 30, 0),
                ActivityId = Guid.Parse("25b00a8d-13b9-4c33-a145-96b89264d699")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("44312107-bbbd-422b-b54b-25a0db36f3b5"),
                StartTime = new DateTime(2023, 08, 11, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 11, 17, 30, 0),
                ActivityId = Guid.Parse("25b00a8d-13b9-4c33-a145-96b89264d699")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("3d254f93-f684-4536-8dc4-523dd7e69794"),
                StartTime = new DateTime(2023, 08, 16, 12, 0, 0),
                EndTime = new DateTime(2023, 08, 16, 13, 30, 0),
                ActivityId = Guid.Parse("25b00a8d-13b9-4c33-a145-96b89264d699")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("3526d1c6-f63a-42c6-ae60-1dd97e3434a0"),
                StartTime = new DateTime(2023, 08, 25, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 25, 17, 30, 0),
                ActivityId = Guid.Parse("25b00a8d-13b9-4c33-a145-96b89264d699")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            return crossTrainSchedules.ToArray();

        }

        private GroupSchedule[] GenerateKickBoxingSchedules()
        {
            ICollection<GroupSchedule> kickBoxingSchedules = new HashSet<GroupSchedule>();

            GroupSchedule kickBoxingSchedule;

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("6d88f805-232d-4ce4-a05f-a62da3a02474"),
                StartTime = new DateTime(2023, 08, 07, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 07, 12, 00, 0),
                ActivityId = Guid.Parse("6d6ee926-6fa3-43a7-8bac-dc86632094a5")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("abd78db4-0a0d-466c-a14d-4f1c6da8bfb0"),
                StartTime = new DateTime(2023, 08, 10, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 10, 12, 0, 0),
                ActivityId = Guid.Parse("6d6ee926-6fa3-43a7-8bac-dc86632094a5")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("bccaca62-a573-47e1-b815-0569bf15dd70"),
                StartTime = new DateTime(2023, 08, 17, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 17, 12, 0, 0),
                ActivityId = Guid.Parse("6d6ee926-6fa3-43a7-8bac-dc86632094a5")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("e499d6b0-a852-4b37-9334-fc5f8c4aa69c"),
                StartTime = new DateTime(2023, 08, 21, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 21, 12, 0, 0),
                ActivityId = Guid.Parse("6d6ee926-6fa3-43a7-8bac-dc86632094a5")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("7c8030e8-e724-4470-adbf-e343a80566a2"),
                StartTime = new DateTime(2023, 08, 28, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 28, 12, 0, 0),
                ActivityId = Guid.Parse("6d6ee926-6fa3-43a7-8bac-dc86632094a5")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            return kickBoxingSchedules.ToArray();

        }

        private GroupSchedule[] GenerateYogaSchedules()
        {
            ICollection<GroupSchedule> groupSchedules = new HashSet<GroupSchedule>();

            GroupSchedule schedule;

            schedule = new GroupSchedule()
            {
                Id = Guid.Parse("296e3b96-8ad1-4ceb-847c-331444d36016"),
                StartTime = new DateTime(2023, 08, 22, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 22, 12, 0, 0),
                ActivityId = Guid.Parse("436818ef-d86c-4e43-88ca-29ff34ad5850")
            };

            groupSchedules.Add(schedule);

            schedule = new GroupSchedule()
            {
                Id = Guid.Parse("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"),
                StartTime = new DateTime(2023, 08, 28, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 28, 12, 0, 0),
                ActivityId = Guid.Parse("436818ef-d86c-4e43-88ca-29ff34ad5850")
            };

            groupSchedules.Add(schedule);

            schedule = new GroupSchedule()
            {
                Id = Guid.Parse("c4d374b1-c657-4f03-a46c-2c725f630375"),
                StartTime = new DateTime(2023, 08, 29, 14, 0, 0),
                EndTime = new DateTime(2023, 08, 29, 16, 0, 0),
                ActivityId = Guid.Parse("436818ef-d86c-4e43-88ca-29ff34ad5850")
            };

            groupSchedules.Add(schedule);

            schedule = new GroupSchedule()
            {
                Id = Guid.Parse("a8ba6cc6-2e6d-4709-ab9b-bc4c4024e29b"),
                StartTime = new DateTime(2023, 08, 30, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 30, 12, 0, 0),
                ActivityId = Guid.Parse("436818ef-d86c-4e43-88ca-29ff34ad5850")
            };

            groupSchedules.Add(schedule);

            return groupSchedules.ToArray();
        }
    }
    
}
