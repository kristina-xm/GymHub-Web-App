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
                Id = Guid.Parse("68cbab08-c836-4166-85cb-81caff531bc5"),
                TraineeId = Guid.Parse("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"),
                ScheduleId = Guid.Parse("47d1b94a-1e4b-4ae4-986d-60298849b1c7"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("1cc5bc09-2e19-49d0-b8cb-066f8b451328"),
                TraineeId = Guid.Parse("b6830fbd-a3e8-4465-a596-04565c4568bc"),
                ScheduleId = Guid.Parse("6d88f805-232d-4ce4-a05f-a62da3a02474"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("9b9ea386-97d6-4ef1-b1f9-01d525ad9b74"),
                TraineeId = Guid.Parse("02f24448-29e7-48d1-ae7e-54282df6cc53"),
                ScheduleId = Guid.Parse("abd78db4-0a0d-466c-a14d-4f1c6da8bfb0"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("139c5fce-bf05-47e3-8fd3-9bb4f338aeb6"),
                TraineeId = Guid.Parse("5546a97c-3ed4-48b7-90c7-2c0d70159e28"),
                ScheduleId = Guid.Parse("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("3bb3b4d4-3e88-4ddc-b972-9a02c005f637"),
                TraineeId = Guid.Parse("44ea1e99-19e1-4d88-80f7-3d13cad88c5c"),
                ScheduleId = Guid.Parse("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"),
            };

            groupEnrollments.Add(groupEnrollment);

            groupEnrollment = new GroupEnrollment()
            {
                Id = Guid.Parse("576dea69-a564-4f60-99b4-b2643eeff00c"),
                TraineeId = Guid.Parse("10d01292-4c4a-46b3-a1d7-e87212c0a87b"),
                ScheduleId = Guid.Parse("c4d374b1-c657-4f03-a46c-2c725f630375"),
            };

            groupEnrollments.Add(groupEnrollment);

            return groupEnrollments.ToArray();
        }
    }
}
