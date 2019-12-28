using DotNetCoreArchitecture.Domain.FastFood.Catogry;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Foods
{
    [Table("FoodBrand")]
    public class FoodBrands
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FoodId")]
        public Guid FoodId { get; set; }

        [Column("FoodName")]
        public string Name { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        /* Catogry Food reference key */

        public FoodCatogryEntity FoodCatogryEntity { get; set; }

        public UserEntity UserEntity { get; set; }



        [ForeignKey("CatogryId")]
        public string CatogryId { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }



        /* user entity reference key */


        [Column("OwnerName")]
        public string OwnerName { get; set; }

        [Column("OwnerPlace")]
        public string OwnerPlace { get; set; }
    }
}
