using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS
{
    [Table("EmployeeContractInfo")]
    public class EmployeeContract : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("ContractName")]
        public string ContractName { get; set; }

        [Column("ContractTitle")]
        public string ContractTitle { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }


        /* employee issuer reference key  */

        /* desired employee reference key */

        /* department reference key       */

        /* contract info reference key    */

        /* contract issuer department     */

        /* organization reference key     */

        [Column("RoleName")]
        public string RoleName { get; set; }

        [Column("MainResponsibility")]
        public string MainResponsibility { get; set; }

        /* role info reference key */
    }
}
