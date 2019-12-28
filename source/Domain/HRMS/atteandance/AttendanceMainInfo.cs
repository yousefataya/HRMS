using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.atteandance
{
    [Table("AttendanceMainInfo")]
    public class AttendanceMainInfo : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

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

        /* employee reference key */

        /* department reference key */

        /* approval employee reference key */

        [Column("Leave")]
        public bool Leave { get; set; }

        [Column("LeaveDate")]
        public DateTime LeaveDate { get; set; }

        [Column("LeaveReason")]
        public string LeaveReason { get; set; }

        /*Absence reference key */


    }
}
