using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GymHub.Common.EntityValidationConstants.Certification;

namespace GymHub.Web.ViewModels.User
{
    public class TrainerCertificateViewModel
    {

        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [StringLength(OrganizationMaxLength, MinimumLength = OrganizationMinLength)]
        public string IssuingOrganization { get; set; } = null!;

        public DateTime IssueDate { get; set; }
    }
}
