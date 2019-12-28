using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.management
{
    [Table("ContractInfo")]
    public class ContractInfo : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("ContractName")]
        public string ContractName { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("EndDate")]
        public DateTime EndDate { get; set; }

        [Column("IsExtenable")]
        public bool IsExtenable { get; set; }

        [Column("ExtendDate")]
        public DateTime ExtendDate { get; set; }

        [Column("AfterExtenEnddDate")]
        public DateTime AfterExtenEnddDate { get; set; }

        /* employee audit reference key */

        /* department reference key */

        /* department role info reference key */
    }
}
