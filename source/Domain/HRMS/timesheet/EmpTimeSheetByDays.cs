using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.timesheet
{
    [Table("EmpSheetSheetByDays")]
    public class EmpTimeSheetByDays : IAuditable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }


        [Column("DayName")]
        public string DayName { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

        [Column("TaskName")]
        public string TaskName { get; set; }

        /* Stage task reference key */

        /* project details reference key */

        /* main employee reference key */

        /* employee advisor reference key */

        [Column("TaskDescription")]
        public string TaskDescription { get; set; }

        [Column("IdustryTools")]
        public string IdustryTools { get; set; }

        /* team info reference key */

        [Column("TaskWrkDays")]
        public string TaskWrkDays { get; set; }

        [Column("WithOverTime")]
        public bool WithOverTime { get; set; }

        [Column("OverTimeFromDate")]
        public DateTime OverTimeFromDate { get; set; }

        [Column("OverTimeToDate")]
        public DateTime OverTimeToDate { get; set; }

        [Column("IsCompleted")]
        public bool IsCompleted { get; set; }

        [Column("CompletedDate")]
        public DateTime CompletedDate { get; set; }

        [Column("IsFail")]
        public bool IsFail { get; set; }

        [Column("FailDate")]
        public DateTime FailDate { get; set; }

    }
}
