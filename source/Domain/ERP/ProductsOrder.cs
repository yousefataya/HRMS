using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.ERP
{
    [Table("ProductsOrderInfo")]
    public class ProductsOrder : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        /* employee issuer reference key */

        /* product reference key */

        /* product reference selling key */

        [Column("OrderName")]
        public string OrderName { get; set; }

        [Column("OrderNo")]
        public string OrderNo { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }

        [Column("OrderCompletedDate")]
        public DateTime OrderCompletedDate { get; set; }

        [Column("IsFail")]
        public bool IsFail { get; set; }

        [Column("FailDate")]
        public DateTime FailDate { get; set; }

        [Column("Desscription")]
        public string Desscription { get; set; }

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
