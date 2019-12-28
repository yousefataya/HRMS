using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.ERP
{
    [Table("ProductTransactionsInfo")]
    public class ProductTransactions : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("TransactionNo")]
        public string TransactionNo { get; set; }

        [Column("TransactionName")]
        public string TransactionName { get; set; }

        /* product reference key */

        [Column("TransactionDate")]
        public DateTime TransactionDate { get; set; }

        [Column("TransactionType")]
        public string TransactionType { get; set; }

        [Column("TransactionMethod")]
        public string TransactionMethod { get; set; }

        /* product order reference key */

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }
    }
}
