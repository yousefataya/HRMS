using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Orders
{
    public class FoodBrandOrderEntityFactory
    {

        public static FoodBrandOrder CreateBuilder()
        {
            return new FoodBrandOrder();
        }


        public static FoodBrandOrder OrderName(FoodBrandOrder cItem, string OrderName)
        {
            cItem.OrderName = OrderName;
            return cItem;
        }


        public static FoodBrandOrder CreatedDate(FoodBrandOrder cItem, DateTime CreatedDate)
        {
            cItem.CreatedDate = CreatedDate;
            return cItem;
        }

    }
}
