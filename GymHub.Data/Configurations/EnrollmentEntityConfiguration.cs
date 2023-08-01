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
    public class EnrollmentEntityConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasData(this.GenerateIndividualEnrollments());
        }

        private Enrollment[] GenerateIndividualEnrollments()
        {
            ICollection<Enrollment> enrollments = new HashSet<Enrollment>();

            Enrollment enrollment;

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("fd2fa2eb-2bce-482e-9f28-08a2a705b6c9"),
                TraineeId = Guid.Parse("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"),
                TrainingId = Guid.Parse("922bf694-a4e1-4fbe-b508-8cbfa836600f"),
            }; 

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("4ce3627a-7ed9-460f-8954-e84bdf978a18"),
                TraineeId = Guid.Parse("b6830fbd-a3e8-4465-a596-04565c4568bc"),
                TrainingId = Guid.Parse("82a1b1c7-1b12-4973-a8c0-9720fe4255fc"),
            };

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("a95ee763-73af-4f1e-9942-30004ccdb826"),
                TraineeId = Guid.Parse("b6830fbd-a3e8-4465-a596-04565c4568bc"),
                TrainingId = Guid.Parse("5bd931f9-f5ca-472c-8c81-9f011118c0e5"),
            };

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("b903e948-dbb2-4177-b9f1-5d2feb46f1a6"),
                TraineeId = Guid.Parse("02f24448-29e7-48d1-ae7e-54282df6cc53"),
                TrainingId = Guid.Parse("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca"),
            };

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("e88db467-0004-4e11-9d80-648316f73a31"),
                TraineeId = Guid.Parse("5546a97c-3ed4-48b7-90c7-2c0d70159e28"),
                TrainingId = Guid.Parse("88034cb7-c971-4520-a3a1-d48099502562"),
            };

            enrollments.Add(enrollment);

            return enrollments.ToArray();
        }
    }
}
