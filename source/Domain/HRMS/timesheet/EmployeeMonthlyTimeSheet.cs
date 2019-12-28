using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.timesheet
{
    [Table("EmployeeMonthlyTimeSheet")]
    public class EmployeeMonthlyTimeSheet : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("SheetName")]
        public string SheetName { get; set; }

        [Column("SheetTitle")]
        public string SheetTitle { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }


        /* employee reference key */

        /* department reference key */

        /* employee advisor reference key */

        /* team main info reference key */


    }
}
