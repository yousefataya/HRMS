using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.meeting
{
    [Table("MeetingAbsence")]
    public class MeetingAbsence : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("AbsenceReason")]
        public string AbsenceReason { get; set; }

        [Column("AbsenceName")]
        public string AbsenceName { get; set; }

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

        /* employee issuer reference key */

        /* absence employee refernce key */

        /* department reference key */

        /* meeting reference key */

        [Column("AbsenceDate")]
        public DateTime AbsenceDate { get; set; }



    }
}
