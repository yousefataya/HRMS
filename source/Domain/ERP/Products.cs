using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.ERP
{
    [Table("ProductsInfo")]
    public class Products : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("ProductName")]
        public string ProductName { get; set; }

        [Column("ProductMarkingTrade")]
        public string ProductMarkingTrade { get; set; }

        [Column("ProductDetails")]
        public string ProductDetails { get; set; }

        [Column("Classifications")]
        public string Classifications { get; set; }

        [Column("Manufactured")]
        public string Manufactured { get; set; }

        /* Catalogue reference key */

        /* employee issuer reference key */

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

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("WarrantyDetails")]
        public string WarrantyDetails { get; set; }
    }
}
