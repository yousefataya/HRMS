using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.OrderStatus
{
    [Table("FoodOrderStatus")]
    public class FoodOrderStatus
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderStatusId")]
        public Guid OrderStatusId { get; set; }


        /* Order reference key */

        [Column("status")]
        public bool Status { get; set; }


        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

    }
}
