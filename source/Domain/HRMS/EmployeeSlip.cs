using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS
{
    [Table("EmployeeSlipInfo")]
    public class EmployeeSlip : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Amount")]
        public int Amount { get; set; }

        [Column("SalaryAmount")]
        public int SalaryAmount { get; set; }

        [Column("CurrencyConvertor")]
        public string CurrencyConvertor { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("TakenDate")]
        public DateTime TakenDate { get; set; }

        /*  employee reference key */

        /*  employee issuer reference key */

        /*  department reference key */


    }
}
