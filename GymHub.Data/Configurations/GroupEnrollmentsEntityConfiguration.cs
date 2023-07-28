using GymHub.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
namespace GymHub.Data.Configurations
{
    public class GroupEnrollmentsEntityConfiguration : IEntityTypeConfiguration<GroupEnrollment>
    {
        public void Configure(EntityTypeBuilder<GroupEnrollment> builder)
        {
            builder.HasData(this.GenerateGroupEnrollments());
        }

        private GroupEnrollment[] GenerateGroupEnrollments()
        {
            ICollection<GroupEnrollment> groupEnrollments = new HashSet<GroupEnrollment>();

            GroupEnrollment groupEnrollment;

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("185f01bb-cb3d-4a44-a718-8da91b77a46a"),
                TraineeId = Guid.Parse("3EE69130-4CE4-450D-BE65-0AB522760278"),
                ScheduleId = Guid.Parse("DA220D33-5A34-46A2-9E95-415AAAFBE7CD"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("b4c5dd72-11d1-4f18-96b3-c03597a0d132"),
                TraineeId = Guid.Parse("EFE69CD0-FF7A-4F5A-B038-18A62654C084"),
                ScheduleId = Guid.Parse("8D827EF7-962B-4A01-A391-88663ECAC213"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("db91e9ab-e05b-4121-b1dd-137d8ac80db9"),
                TraineeId = Guid.Parse("C4E34109-23BA-42A1-9A17-3797090DE18C"),
                ScheduleId = Guid.Parse("8D827EF7-962B-4A01-A391-88663ECAC213"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("21fe6937-bd86-44af-8c25-3740756f3943"),
                TraineeId = Guid.Parse("F5C10860-7074-4121-AE6A-F8E6B832340B"),
                ScheduleId = Guid.Parse("6104AE44-7737-4BFE-9146-969C78F8664B"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("9a28747c-0dd9-4a0f-b489-78c2ae91d8fb"),
                TraineeId = Guid.Parse("E89FC950-317B-454B-9C66-C082DB3CBEC2"),
                ScheduleId = Guid.Parse("B3A5CC92-FD09-4FE0-89A9-F6BD98BF90E1"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("5ec7ebbf-9791-4607-a03c-5a0278a4ba88"),
                TraineeId = Guid.Parse("F5C10860-7074-4121-AE6A-F8E6B832340B"),
                ScheduleId = Guid.Parse("B3A5CC92-FD09-4FE0-89A9-F6BD98BF90E1"),
            };

            groupEnrollments.Add(groupEnrollment);

            return groupEnrollments.ToArray();
        }
    }
}
