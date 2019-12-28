using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.ProjectInfo
{
    [Table("StageTasksInfo")]
    public class StageTasks : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("TaskName")]
        public string TaskName { get; set; }

        [Column("TaskNo")]
        public string TaskNo { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("MaxDays")]
        public string MaxDays { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        /*employee issue reference key */

        /*employee solve issue reference key */

        /*employe advisor reference key */

        /*department reference key */

        /* organization reference key */

    }
}
