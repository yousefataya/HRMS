using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.leadership
{
    [Table("TeamMainInfo")]
    public class TeamMainInfo : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("TeamName")]
        public string TeamName { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("AllWorkingHours")]
        public DateTime AllWorkingHours { get; set; }

        [Column("WeeklyStart")]
        public string WeeklyStart { get; set; }

        [Column("WeeklyEnd")]
        public string WeeklyEnd { get; set; }

        /* department reference key */

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("ExpierdDate")]
        public DateTime ExpierdDate { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }
    }
}
