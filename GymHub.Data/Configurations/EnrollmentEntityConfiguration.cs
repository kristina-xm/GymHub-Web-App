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
                TraineeId = Guid.Parse("EFE69CD0-FF7A-4F5A-B038-18A62654C084"),
                TrainingId = Guid.Parse("63d1f1d6-9348-4710-8082-20a1fbf189e2"),
            }; 

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("4ce3627a-7ed9-460f-8954-e84bdf978a18"),
                TraineeId = Guid.Parse("EFE69CD0-FF7A-4F5A-B038-18A62654C084"),
                TrainingId = Guid.Parse("3e154226-2820-4837-81c8-247e4604cdd6"),
            };

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("a95ee763-73af-4f1e-9942-30004ccdb826"),
                TraineeId = Guid.Parse("E89FC950-317B-454B-9C66-C082DB3CBEC2"),
                TrainingId = Guid.Parse("66afc146-91e8-461f-a9c2-8b61419f6af3"),
            };

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("b903e948-dbb2-4177-b9f1-5d2feb46f1a6"),
                TraineeId = Guid.Parse("F5C10860-7074-4121-AE6A-F8E6B832340B"),
                TrainingId = Guid.Parse("a2b6df44-832f-4ae2-ae77-4f8bc89a66af"),
            };

            enrollments.Add(enrollment);

            enrollment = new Enrollment()
            {
                Id = Guid.Parse("e88db467-0004-4e11-9d80-648316f73a31"),
                TraineeId = Guid.Parse("3EE69130-4CE4-450D-BE65-0AB522760278"),
                TrainingId = Guid.Parse("492b5886-64cf-4f0e-9fdb-2baed606e361"),
            };

            enrollments.Add(enrollment);

            return enrollments.ToArray();
        }
    }
}
