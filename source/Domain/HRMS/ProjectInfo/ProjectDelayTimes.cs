using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.ProjectInfo
{
    [Table("ProjectDelayTimes")]
    public class ProjectDelayTimes : IAuditable 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("DelayNo")]
        public string DelayNo { get; set; }

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

        [Column("DeadLineAfterExtend")]
        public DateTime DeadLineAfterExtend { get; set; }

        /* project info reference key */

        /* department reference key */

        /* employee issuer reference key */

        /* employee advisor reference key */



    }
}
