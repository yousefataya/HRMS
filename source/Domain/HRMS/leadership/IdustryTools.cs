using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.leadership
{
    [Table("IdustryToolsInfo")]
    public class IdustryTools : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("ToolName")]
        public string ToolName { get; set; }

        [Column("InvlovedDate")]
        public DateTime InvlovedDate { get; set; }

        [Column("StanderName")]
        public string StanderName { get; set; }

        [Column("YearlyWorking")]
        public int YearlyWorking { get; set; }

        [Column("MonthlyWorking")]
        public int MonthlyWorking { get; set; }

        [Column("DaysWorking")]
        public int DaysWorking { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("OutSourcing")]
        public bool OutSourcing { get; set; }

        [Column("OutSourceingDate")]
        public DateTime OutSourceingDate { get; set; }

        [Column("DesiredSection")]
        public string DesiredSection { get; set; }

        [Column("OutSourceCompany")]
        public string OutSourceCompany { get; set; }

        /* department reference key */

        /* Team Main Info reference key */

        /* team leader main employee reference key */

        /* Team industry reference key */

    }
}
