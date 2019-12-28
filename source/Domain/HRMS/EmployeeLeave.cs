using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS
{
    [Table("EmployeeLeaveInfo")]
    public class EmployeeLeave : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("LeaveTitle")]
        public string LeaveTitle { get; set; }

        [Column("LeaveReason")]
        public string LeaveReason { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

        [Column("MaxHours")]
        public int MaxHours { get; set; }

        [Column("SpecialLeave")]
        public bool SpecialLeave { get; set; }

        [Column("SpecialLeaveToDate")]
        public DateTime SpecialLeaveToDate { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        /* employee issuer reference key */

        /* employee disred reference key */

        /* department reference key */

        /* team main info reference key */
    }
}
