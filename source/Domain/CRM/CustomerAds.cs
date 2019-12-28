using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.CRM
{
    [Table("CustomerAdsInfo")]
    public class CustomerAds : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("AdsName")]
        public string AdsName { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

        [Column("AdsText")]
        public string AdsText { get; set; }

        /* customer reference key */

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

    }
}
