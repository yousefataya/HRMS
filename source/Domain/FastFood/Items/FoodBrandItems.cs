using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Items
{
    [Table("FoodBrandItems")]
    public class FoodBrandItems
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ItemId { get; set; }

        [Column("ItemName")]
        public string ItemName { get; set; }

        [Column("ItemType")]
        public string ItemType { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        public ItemTypeEntity ItemTypeEntity { get; set; }

        [ForeignKey("ItemTypeId")]
        public string ItemTypeId { get; set; }

        public ItemTypeCatogry ItemTypeCatogry { get; set; }

        [ForeignKey("ItemTypeCatogryId")]
        public string ItemTypeCatogryId { get; set; }

        /* Item Type reference key */

        /* Item Catogry reference key */



    }
}
