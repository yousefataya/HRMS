using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace DotNetCoreArchitecture.Domain.Accounting.Auditing
{
    [Table("UserChanges")]
    public class UserChanges : IAuditable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("LogText")]
        public string LogText { get; set; }

        [Column("RootClazz")]
        public string RootClazz { get; set; }

        [Column("MethodName")]
        public string MethodName { get; set; }



        /* employee reference key */

        /* deptartment reference key */


    }
}
