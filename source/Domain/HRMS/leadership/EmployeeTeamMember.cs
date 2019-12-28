using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.leadership
{
    [Table("EmployeeTeamMember")]
    public class EmployeeTeamMember : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("FisrtName")]
        public string FisrtName { get; set; }

        [Column("SecondName")]
        public string SecondName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

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

        [Column("JoinDate")]
        public DateTime JoinDate { get; set; }

        /* Team main info reference key */

        [Column("IsLeaved")]
        public bool IsLeaved { get; set; }

        [Column("LeaveDate")]
        public DateTime LeaveDate { get; set; }

        [Column("RoleName")]
        public string RoleName { get; set; }

        /* role reference key */

    }
}
