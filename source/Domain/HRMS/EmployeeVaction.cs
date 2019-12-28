using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS
{
    [Table("EmployeeVactionInfo")]
    public class EmployeeVaction : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("VacationTitle")]
        public string VacationTitle { get; set; }

        [Column("VacationName")]
        public string VacationName { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }



        /* employee issuer reference key */

        /* desired employee reference key */

        [Column("IsBreakVacation")]
        public bool IsBreakVacation { get; set; }

        [Column("BreakVacationDate")]
        public DateTime BreakVacationDate { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

    }
}
