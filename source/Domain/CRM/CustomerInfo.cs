using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.CRM
{
    [Table("CustomerInfo")]
    public class CustomerInfo : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("CustomerFName")]
        public string CustomerFName { get; set; }

        [Column("CustomerSecondName")]
        public string CustomerSecondName { get; set; }

        [Column("Gender")]
        public string Gender { get; set; }

        [Column("Age")]
        public int Age { get; set; }

        [Column("CustomerLName")]
        public string CustomerLName { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("ExpierdDate")]
        public DateTime ExpierdDate { get; set; }

    }
}
