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
                TraineeId = Guid.Parse("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"),
                ScheduleId = Guid.Parse("DA220D33-5A34-46A2-9E95-415AAAFBE7CD"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("b4c5dd72-11d1-4f18-96b3-c03597a0d132"),
                TraineeId = Guid.Parse("b6830fbd-a3e8-4465-a596-04565c4568bc"),
                ScheduleId = Guid.Parse("8D827EF7-962B-4A01-A391-88663ECAC213"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("db91e9ab-e05b-4121-b1dd-137d8ac80db9"),
                TraineeId = Guid.Parse("02f24448-29e7-48d1-ae7e-54282df6cc53"),
                ScheduleId = Guid.Parse("8D827EF7-962B-4A01-A391-88663ECAC213"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("21fe6937-bd86-44af-8c25-3740756f3943"),
                TraineeId = Guid.Parse("5546a97c-3ed4-48b7-90c7-2c0d70159e28"),
                ScheduleId = Guid.Parse("6104AE44-7737-4BFE-9146-969C78F8664B"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("9a28747c-0dd9-4a0f-b489-78c2ae91d8fb"),
                TraineeId = Guid.Parse("44ea1e99-19e1-4d88-80f7-3d13cad88c5c"),
                ScheduleId = Guid.Parse("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("5ec7ebbf-9791-4607-a03c-5a0278a4ba88"),
                TraineeId = Guid.Parse("10d01292-4c4a-46b3-a1d7-e87212c0a87b"),
                ScheduleId = Guid.Parse("296e3b96-8ad1-4ceb-847c-331444d36016"),
            };

            groupEnrollments.Add(groupEnrollment);

            return groupEnrollments.ToArray();
        }
    }
}
