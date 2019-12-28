using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.leadership
{
    [Table("EmployeeLeadersTeam")]
    public class EmployeeLeadersTeam : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("TeamName")]
        public string TeamName { get; set; }

        [Column("TeamIssueDate")]
        public DateTime TeamIssueDate { get; set; }

        [Column("TeamMainRole")]
        public string TeamMainRole { get; set; }

        /* employee main role key */

        /* employee main advisor key */

        /* department reference key */

        /* department manjor employee reference key */

        /* Team Main Info reference key */

        [Column("FirstName")]
        public string FirstName { get; set; }

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

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }
    }
}
