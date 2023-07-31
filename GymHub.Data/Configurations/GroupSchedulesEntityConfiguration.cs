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
        }

        public GroupSchedule[] GenerateCrossTrainingSchedules()
        {
            ICollection<GroupSchedule> crossTrainSchedules = new HashSet<GroupSchedule>();

            GroupSchedule crossTrainSchedule;

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("5ea2a2d0-10f6-4fff-a4a5-28ce33c5a5ec"),
                StartTime = new DateTime(2023, 08, 08, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 08, 17, 30, 0),
                ActivityId = Guid.Parse("0bb32c51-d799-4004-915f-91ccea62ce11")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("a9a81c48-7e25-469e-8f61-75b4669c1b4a"),
                StartTime = new DateTime(2023, 08, 22, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 22, 17, 30, 0),
                ActivityId = Guid.Parse("0bb32c51-d799-4004-915f-91ccea62ce11")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("8d827ef7-962b-4a01-a391-88663ecac213"),
                StartTime = new DateTime(2023, 08, 11, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 11, 17, 30, 0),
                ActivityId = Guid.Parse("0bb32c51-d799-4004-915f-91ccea62ce11")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            crossTrainSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"),
                StartTime = new DateTime(2023, 08, 25, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 25, 17, 30, 0),
                ActivityId = Guid.Parse("0bb32c51-d799-4004-915f-91ccea62ce11")
            };

            crossTrainSchedules.Add(crossTrainSchedule);

            return crossTrainSchedules.ToArray();

        }

        public GroupSchedule[] GenerateKickBoxingSchedules()
        {
            ICollection<GroupSchedule> kickBoxingSchedules = new HashSet<GroupSchedule>();

            GroupSchedule kickBoxingSchedule;

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("f1f607d8-e1e2-4ca8-9bda-caa1cfd0c31f"),
                StartTime = new DateTime(2023, 08, 07, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 07, 12, 00, 0),
                ActivityId = Guid.Parse("6ad5a4d2-11fa-4fee-89e6-a341a47bf527")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("6104ae44-7737-4bfe-9146-969c78f8664b"),
                StartTime = new DateTime(2023, 08, 14, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 14, 12, 0, 0),
                ActivityId = Guid.Parse("6ad5a4d2-11fa-4fee-89e6-a341a47bf527")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("539d5620-f636-439c-a7d5-94f3b3654f70"),
                StartTime = new DateTime(2023, 08, 21, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 21, 12, 0, 0),
                ActivityId = Guid.Parse("6ad5a4d2-11fa-4fee-89e6-a341a47bf527")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            kickBoxingSchedule = new GroupSchedule()
            {
                Id = Guid.Parse("da220d33-5a34-46a2-9e95-415aaafbe7cd"),
                StartTime = new DateTime(2023, 08, 28, 10, 0, 0),
                EndTime = new DateTime(2023, 08, 28, 12, 0, 0),
                ActivityId = Guid.Parse("6ad5a4d2-11fa-4fee-89e6-a341a47bf527")
            };

            kickBoxingSchedules.Add(kickBoxingSchedule);

            return kickBoxingSchedules.ToArray();

        }
    }
    
}
