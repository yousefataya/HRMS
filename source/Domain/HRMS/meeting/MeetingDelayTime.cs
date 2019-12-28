using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.meeting
{
    [Table("MeetingDelayTime")]
    public class MeetingDelayTime : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("DelayReason")]
        public string DelayReason { get; set; }

        [Column("DelayTitle")]
        public string DelayTitle { get; set; }

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

        /* employee issuer reference key */

        /* department reference key */

        /* meeting main info reference key */

        [Column("AfetrDelayMeetingDate")]
        public DateTime AfetrDelayMeetingDate { get; set; }

        [Column("MaxDaysToDelay")]
        public string MaxDaysToDelay { get; set; }

    }
}
