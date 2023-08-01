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
                Id = Guid.Parse("5ea2a2d0-10f6-4fff-a4a5-28ce33c5a5ec"),
                StartTime = new DateTime(2023, 08, 08, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 08, 17, 30, 0),
                ActivityId = Guid.Parse("25b00a8d-13b9-4c33-a145-96b89264d699")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("a9a81c48-7e25-469e-8f61-75b4669c1b4a"),
                StartTime = new DateTime(2023, 08, 22, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 22, 17, 30, 0),
                ActivityId = Guid.Parse("25b00a8d-13b9-4c33-a145-96b89264d699")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("8d827ef7-962b-4a01-a391-88663ecac213"),
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
                Id = Guid.Parse("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"),
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
                Id = Guid.Parse("f1f607d8-e1e2-4ca8-9bda-caa1cfd0c31f"),
                StartTime = new DateTime(2023, 08, 07, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 07, 12, 00, 0),
                ActivityId = Guid.Parse("6d6ee926-6fa3-43a7-8bac-dc86632094a5")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("6104ae44-7737-4bfe-9146-969c78f8664b"),
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
                Id = Guid.Parse("539d5620-f636-439c-a7d5-94f3b3654f70"),
                StartTime = new DateTime(2023, 08, 21, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 21, 12, 0, 0),
                ActivityId = Guid.Parse("6d6ee926-6fa3-43a7-8bac-dc86632094a5")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("da220d33-5a34-46a2-9e95-415aaafbe7cd"),
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
