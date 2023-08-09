namespace GymHub.Data.Configurations
{
    using GymHub.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    public class CertificationTrainerEntityConfiguration : IEntityTypeConfiguration<TrainerCertification>
    {
        public void Configure(EntityTypeBuilder<TrainerCertification> builder)
        {
            builder.HasData(this.SeedTrainersCertifications());
        }

        private TrainerCertification[] SeedTrainersCertifications()
        {
            ICollection<TrainerCertification> trainerCertifications= new HashSet<TrainerCertification>();

            TrainerCertification trainerCertification;

            trainerCertification = new TrainerCertification()
            {
                CertificationId = Guid.Parse("abc5ab25-3e76-43cb-be4b-2b05b50e7893"),
                TrainerId = Guid.Parse("1495C1E6-C21D-4B6F-B64D-A47D0226F4FC")
            };

            trainerCertifications.Add(trainerCertification);

            trainerCertification = new TrainerCertification()
            {
                CertificationId = Guid.Parse("8d52ff35-fcfc-4385-ae23-a45be1db42f4"),
                TrainerId = Guid.Parse("7B785253-5315-49FE-9D0C-39A8935C6902")
            };

            trainerCertifications.Add(trainerCertification);

            trainerCertification = new TrainerCertification()
            {
                CertificationId = Guid.Parse("a108e18e-436d-4b80-b651-f06dc7dfc6fd"),
                TrainerId = Guid.Parse("3FCAA2A4-59E1-4AF4-9146-6F30716F836C")
            };

            trainerCertifications.Add(trainerCertification);

            trainerCertification = new TrainerCertification()
            {
                CertificationId = Guid.Parse("5d8ce6bd-4def-4e06-beba-9beca0a08f94"),
                TrainerId = Guid.Parse("D1079610-D657-4CEA-BF9B-0FC1053A6EE8")
            };

            trainerCertifications.Add(trainerCertification);

            return trainerCertifications.ToArray();
        }
    }
}
