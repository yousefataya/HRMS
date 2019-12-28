using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.ERP
{
    [Table("ProductAvailabilityInfo")]
    public class ProductAvailability : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("IsAvailable")]
        public bool IsAvailable { get; set; }

        [Column("AvailableDate")]
        public DateTime AvailableDate { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("NotAvailableDate")]
        public DateTime NotAvailableDate { get; set; }

        /* product reference key */

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }
    }
}
