using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.Auditing
{
    [Table("CrmAuditingLog")]
    public class CrmAuditing
    {
        public Guid Id { get; set; }

        [Column("RootEntityName")]
        public string RootEntityName { get; set; }

        [Column("EntityName")]
        public string EntityName { get; set; }

        [Column("EntityId")]
        public string EntityId { get; set; }

        [Column("OldValue")]
        public string OldValue { get; set; }

        [Column("NewValue")]
        public string NewValue { get; set; }

        [Column("ChangedAt")]
        public DateTimeOffset ChangedAt { get; set; }

        [Column("State")]
        public string State { get; set; }

        [Column("ChangedBy")]
        public string ChangedBy { get; set; }

        [Column("RootEntityId")]
        public string RootEntityId { get; set; }

    }
}
