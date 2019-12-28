using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Items
{
    public class ItemTypeCatogry
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ItemTypeCatogryId")]
        public Guid ItemTypeCatogryId { get; set; }

        [Column("CatogryKey")]
        public string CatogryKey { get; set; }

        [Column("CatogryDescription")]
        public string CatogryDescription { get; set; }

    }
}
