using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.ProjectInfo
{
    [Table("ProjectDetailsInfo")]
    public class ProjectDetails : IAuditable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("ProjectName")]
        public string ProjectName { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("ProjectNo")]
        public string ProjectNo { get; set; }

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

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("DeadLine")]
        public DateTime DeadLine { get; set; }

        [Column("IssueReason")]
        public string IssueReason { get; set; }

        /* employee issuer reference key  */

        /* key employee reference key */

        [Column("WillExtend")]
        public bool WillExtend { get; set; }

        [Column("ExtendDate")]
        public DateTime ExtendDate { get; set; }

        [Column("ExtendTotalPeriod")]
        public string ExtendTotalPeriod { get; set; }

        [Column("DeadLineAfterExtend")]
        public DateTime DeadLineAfterExtend { get; set; }


    }
}
