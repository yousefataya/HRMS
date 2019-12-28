using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.appointment
{
    [Table("AppointmentAttendance")]
    public class AttendancePeople : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("SecondName")]
        public string SecondName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        /* gender lookup reference key  */

        /* person lookup reference key  */

        /* appointment reference key    */

        [Column("Age")]
        public int Age { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        /* Country reference key */

        /* City Reference Key   */

        /* department reference key */

        /* employee resposible reference key */

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

    }
}
