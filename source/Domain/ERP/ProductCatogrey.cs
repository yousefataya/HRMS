using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.ERP
{
    [Table("ProductCatogreyInfo")]
    public class ProductCatogrey : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }


        [Column("CatogryName")]
        public string CatogryName { get; set; }

        [Column("CatogryKey")]
        public string CatogryKey { get; set; }

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
