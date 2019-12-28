using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.meeting
{
    [Table("MeetingMainInfo")]
    public class MeetingMainInfo : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("MeetingName")]
        public string MeetingName { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("IssuePlace")]
        public string IssuePlace { get; set; }

        [Column("MainRole")]
        public string MainRole { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("Inwaiting")]
        public bool Inwaiting { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("BeginDateTime")]
        public DateTime BeginDateTime { get; set; }

        [Column("IsDelay")]
        public bool IsDelay { get; set; }

        [Column("DelayDateTime")]
        public DateTime DelayDateTime { get; set; }

        [Column("DelayReason")]
        public string DelayReason { get; set; }

        /* employee issuer reference key */

        /* department reference key */

        /* main role info department reference key */

        /* room info reference key */

    }
}
