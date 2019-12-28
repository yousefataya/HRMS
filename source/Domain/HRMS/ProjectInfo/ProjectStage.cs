using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.ProjectInfo
{
    [Table("ProjectStage")]
    public class ProjectStage : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("StageName")]
        public string StageName { get; set; }

        [Column("StageNo")]
        public string StageNo { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

        [Column("DeadLineDateTime")]
        public DateTime DeadLineDateTime { get; set; }

        [Column("WillExtend")]
        public bool WillExtend { get; set; }

        [Column("DeadLineAfterExtend")]
        public DateTime DeadLineAfterExtend { get; set; }

        [Column("DelayReason")]
        public string DelayReason { get; set; }

        /* department reference key */

        /* employee issuer key reference */

        /* main employee reference key */

        [Column("MainRole")]
        public string MainRole { get; set; }

        /* project reference key */

        /* project catogry reference key */

        /* team reference key */

        /* */

    }
}
