using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS
{
    [Table("EmployeePerformanceInfo")]
    public class EmployeePerformance : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("PerfomanceTitle")]
        public string PerfomanceTitle { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { set; get; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("Weakness")]
        public string Weakness { get; set; }

        [Column("Strengths")]
        public string Strengths { get; set; }

        [Column("CompletedDate")]
        public DateTime CompletedDate { get; set; }

        [Column("FinalResult")]
        public string FinalResult { get; set; }

        /* employee issuer reference key */

        /* desired employee reference key */

        /* department reference key */

        /* orgainzation reference key */

        /* team main info reference key */
    }
}
