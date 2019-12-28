using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.appointment
{
    [Table("AppointmentMainInfo")]
    public class AppointmentMainInfo : IAuditable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("AppointmentName")]
        public string AppointmentName { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("Notification")]
        public string Notification { get; set; }

        [Column("MeetingDate")]
        public DateTime MeetingDate { get; set; }

        [Column("FinalResult")]
        public string FinalResult { get; set; }

        /* main role reference key */

        /* employee main leader key */

        /* department reference key */




    }
}
