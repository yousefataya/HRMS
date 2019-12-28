using DotNetCoreArchitecture.Domain.FastFood.Foods;
using DotNetCoreArchitecture.Domain.FastFood.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.HistoryOrders
{
    [Table("FoodOrderHistory")]
    public class FoodOrderHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderHistoryId")]
        public Guid OrderHistoryId { get; set; }


        /* Order reference key */


        public FoodBrandOrder FoodBrands { get; set; }

        [ForeignKey("OrderId")]
        public string OrderId { get; set; }


        [Column("status")]
        public bool IsExpired { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }


        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

    }
}
