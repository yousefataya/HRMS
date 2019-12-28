using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS
{
    [Table("EmployeeInfo")]
    public class EmployeeInfo : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("SecondName")]
        public string SecondName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Age")]
        public int Age { get; set; }

        [Column("Gender")]
        public string Gender { get; set; }


        /* department reference key */

        /* team info main reference key */

        /* organization reference key */

        [Column("FullName")]
        public string FullName { get; set; }

        [Column("PassportNo")]
        public string PassportNo { get; set; }

        [Column("CardId")]
        public string CardId { get; set; }


    }
}
