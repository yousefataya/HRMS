using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.CRM
{
    [Table("CustomerServicesInfo")]
    public class CustomerServices : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("ServiceName")]
        public string ServiceName { get; set; }

        [Column("ServiceType")]
        public string ServiceType { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        /* customer reference key */
        /* employee issuer reference key */

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

        [Column("Present")]
        public bool Present { get; set; }

        [Column("IsExpanded")]
        public bool IsExpanded { get; set; }

    }
}
