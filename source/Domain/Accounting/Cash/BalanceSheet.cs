using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.Accounting.Cash
{
    [Table("BalanceSheetMainInfo")]
    public class BalanceSheet : IAuditable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("SheetName")]
        public string SheetName { get; set; }

        /* reference from libitities and assest */


    }
}
