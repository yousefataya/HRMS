using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Catogry
{
    [Table("FoodCatogry")]
    public class FoodCatogryEntity
    {
        public FoodCatogryEntity(string Description) { this.Description = Description; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CatogryId { get; set; }

        [Column("CatogryKey")]
        public string Description { get; set; }

    }
}
