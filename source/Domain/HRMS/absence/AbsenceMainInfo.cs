using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.absence
{
    [Table("AbsenceMainInfo")]
    public class AbsenceMainInfo : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column(name: "AbsenceName")]
        public string AbsenceName { get; set; }

        [Column("AbsenceReason")]
        public string AbsenceReason { get; set; }

        [Column("Note")]
        public string Note { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("AbsenceDate")]
        public DateTime AbsenceDate { get; set; }


        /* employee reference key */


        /* department reference key */

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }


        /* Absence lookup type */


        /* employee manager responsible */
        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        /* Process Execution Id */

        /* attendance reference key */


    }
}
