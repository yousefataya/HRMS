using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.management.department
{
    [Table("DepartmentRoleInfo")]
    public class DepartmentRoleInfo : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("RoleName")]
        public string RoleName { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

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

        [Column("READ")]
        public bool READ { get; set; }

        [Column("UPDATE")]
        public bool UPDATE { get; set; }

        [Column("DELETE")]
        public bool DELETE { get; set; }

        [Column("REPORT")]
        public bool REPORT { get; set; }
    }
}
