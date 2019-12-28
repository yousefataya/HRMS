using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS
{
    [Table("EmployeeEvaluationsInfo")]
    public class EmployeeEvaluations : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("EvaluationName")]
        public string EvaluationName { get; set; }

        [Column("EvaluationTitle")]
        public string EvaluationTitle { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

        [Column("ExtendToDate")]
        public DateTime ExtendToDate { get; set; }

        [Column("IsExtendable")]
        public bool IsExtendable { get; set; }

        [Column("DeadLine")]
        public DateTime DeadLine { get; set; }

        /* employee issuer reference key */

        /* desired employee refgerence key */

        /* department reference key */

        /* organization reference key */

        [Column("MainRole")]
        public string MainRole { get; set; }

        [Column("AdvisorName")]
        public string AdvisorName { get; set; }

        /* main role info reference key */

        /* team main info reference key */

        /* */

    }
}
