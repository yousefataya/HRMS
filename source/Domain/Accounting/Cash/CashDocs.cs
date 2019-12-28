using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.Accounting.Cash
{
    [Table("CashDocs")]
    public class CashDocs : IAuditable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }


        [Column("DocName")]
        public string DocName { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("ExpireDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("Doc")]
        public byte[] Doc { get; set; }

        [Column("FileExtension")]
        public string FileExtension { get; set; }
    }
}
