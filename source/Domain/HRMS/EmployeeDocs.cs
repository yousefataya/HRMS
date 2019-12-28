using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS
{
    [Table("EmployeeDocsInfo")]
    public class EmployeeDocs : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("FileName")]
        public string FileName { get; set; }

        [Column("FileExtension")]
        public string FileExtension { get; set; }

        [Column("Doc")]
        public byte[] Doc { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        /* employee issuer reference key */

        /* desired employee reference key */

        /* department reference key */

        /* organization reference key */

        [Column("DocIssueDate")]
        public string DocIssueDate { get; set; }

        /* contract info reference key */


    }
}
