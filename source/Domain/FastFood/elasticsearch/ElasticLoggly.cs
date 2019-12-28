using DotNetCoreArchitecture.Domain.FastFood.Foods;
using DotNetCoreArchitecture.Domain.FastFood.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.elasticsearch
{
    [Table("ElasticLoggly")]
    public class ElasticLoggly
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LogglyId { get; set; }

        [Column("LogText")]
        public string LogText { get; set; }

        [Column("MethodName")]
        public string MethodName { get; set; }

        [Column("ClazzName")]
        public string ClazzName { get; set; }

        [Column("FoodEntityLogText")]
        public bool FoodEntityLogText { get; set; }

        [Column("FoodOrderEntityLog")]
        public bool FoodOrderLogText { get; set; }


        public FoodBrands FoodBrands { get; set; }

        public FoodBrandOrder FoodBrandOrder { get; set; }


        [ForeignKey("FoodId")]
        public string FoodId { get; set; }


        [ForeignKey("OrderId")]
        public string OrderId { get; set; }


        /* food entity reference key */


        /* order food reference key */
    }
}
