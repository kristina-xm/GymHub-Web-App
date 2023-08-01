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
                Id = Guid.Parse("96faeece-d48a-4039-ba74-48aef7c37505"),
                TraineeId = Guid.Parse("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"),
                TrainingId = Guid.Parse("922bf694-a4e1-4fbe-b508-8cbfa836600f"),
            }; 

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("da72aef2-fed5-47c6-b6b4-f0433b2347fc"),
                TraineeId = Guid.Parse("b6830fbd-a3e8-4465-a596-04565c4568bc"),
                TrainingId = Guid.Parse("82a1b1c7-1b12-4973-a8c0-9720fe4255fc"),
            };

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("f2a2d524-be88-4c27-9a99-b17a33619a64"),
                TraineeId = Guid.Parse("b6830fbd-a3e8-4465-a596-04565c4568bc"),
                TrainingId = Guid.Parse("5bd931f9-f5ca-472c-8c81-9f011118c0e5"),
            };

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("91898c44-8c40-4c2f-8b4b-d2992a4166c3"),
                TraineeId = Guid.Parse("02f24448-29e7-48d1-ae7e-54282df6cc53"),
                TrainingId = Guid.Parse("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca"),
            };

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("8e03520b-84bd-4aec-a19e-b6a461a18609"),
                TraineeId = Guid.Parse("5546a97c-3ed4-48b7-90c7-2c0d70159e28"),
                TrainingId = Guid.Parse("88034cb7-c971-4520-a3a1-d48099502562"),
            };

            enrollments.Add(enrollment);

            return enrollments.ToArray();
        }
    }
}
