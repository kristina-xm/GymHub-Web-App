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
    public class CertificationEntityConfiguration : IEntityTypeConfiguration<Certification>
    {
        public void Configure(EntityTypeBuilder<Certification> builder)
        {
            builder.HasData(this.SeedCertifications());
        }

        private Certification[] SeedCertifications()
        {
            ICollection<Certification> certifications = new HashSet<Certification>();

            Certification certification;

            certification = new Certification()
            {
                Id = Guid.Parse("8d52ff35-fcfc-4385-ae23-a45be1db42f4"),
                Name = "Internationally Accredited Diploma Certificate in Fitness",
                IssuingOrganization = "Alison",
                IssueDate = new DateTime(2019, 05, 23, 0, 0, 0)
            };

            certifications.Add(certification);

            certification = new Certification()
            {
                Id = Guid.Parse("abc5ab25-3e76-43cb-be4b-2b05b50e7893"),
                Name = "Registered Yoga Teacher (RYT)",
                IssuingOrganization = "Yoga Alliance Teacher Training",
                IssueDate = new DateTime(2022, 06, 15, 0, 0, 0)
            };

            certifications.Add(certification);

            certification = new Certification()
            {
                Id = Guid.Parse("a108e18e-436d-4b80-b651-f06dc7dfc6fd"),
                Name = "Personal Trainer",
                IssuingOrganization = "The National Academy of Sports Medicine (NASM)",
                IssueDate = new DateTime(2021, 12, 03, 0, 0, 0)
            };

            certifications.Add(certification);

            certification = new Certification()
            {
                Id = Guid.Parse("5d8ce6bd-4def-4e06-beba-9beca0a08f94"),
                Name = "Martial Arts Trainer",
                IssuingOrganization = "The International Sports Sciences Association (ISSA)",
                IssueDate = new DateTime(2021, 12, 03, 0, 0, 0)
            };

            certifications.Add(certification);

            return certifications.ToArray();    
        }
    }
}
