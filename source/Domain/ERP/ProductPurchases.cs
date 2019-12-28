using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.ERP
{
    [Table("ProductPurchasesInfo")]
    public class ProductPurchases : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }


        /* product reference key */

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("PurchaseDate")]
        public DateTime PurchaseDate { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("PurchaseDetails")]
        public string PurchaseDetails { get; set; }

        [Column("Isdelivered")]
        public bool Isdelivered { get; set; }

        [Column("DeliveredDate")]
        public DateTime DeliveredDate { get; set; }

        [Column("TaxPerecntage")]
        public string TaxPerecntage { get; set; }

        [Column("TaxAmount")]
        public int TaxAmount { get; set; }

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
