using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Items
{
    public class ItemTypeEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ItemTypeId { get; set; }

        [Column("ItemKey")]
        public string ItemKey { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }
    }
}
