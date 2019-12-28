using DotNetCoreArchitecture.Domain.FastFood.Foods;
using DotNetCoreArchitecture.Domain.FastFood.OrderStatus;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Orders
{
    [Table("FoodBrandOrder")]
    public class FoodBrandOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }


        [Column("OrderName")]
        public string OrderName { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }


        public FoodBrands FoodBrands { get; set; }


        [ForeignKey("FoodId")]
        public string FoodId { get; set; }

        /* Food reference key */

        public UserEntity UserEntity { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }


        public FoodOrderStatus FoodOrderStatus { get; set; }

        [ForeignKey("OrderStatusId")]
        public string OrderStatusId { get; set; }

    }
}
