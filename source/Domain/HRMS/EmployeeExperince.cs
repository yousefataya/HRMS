using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS
{
    [Table("EmployeeExperinceInfo")]
    public class EmployeeExperince : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("ExperienceName")]
        public string ExperienceName { get; set; }

        [Column("ExperinceYearly")]
        public int ExperinceYearly { get; set; }

        [Column("ExperinceMonthly")]
        public int ExperinceMonthly { get; set; }

        [Column("ExpeincesDays")]
        public int ExpeincesDays { get; set; }

        [Column("ExperinceUsedProject")]
        public string ExperinceUsedProject { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }


        /* employee issuer reference key   */

        /* desired employee reference key  */

        /* team main info reference key    */

        /* department reference key        */

        [Column("LastUsed")]
        public DateTime LastUsed { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

        [Column("Configuration")]
        public string Configuration { get; set; }

        [Column("Skills")]
        public string Skills { get; set; }
    }
}
