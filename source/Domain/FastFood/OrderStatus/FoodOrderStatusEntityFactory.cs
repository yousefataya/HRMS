using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.OrderStatus
{
    public class FoodOrderStatusEntityFactory
    {

        public static FoodOrderStatus CreateBuilder()
        {
            return new FoodOrderStatus();
        }

        public static FoodOrderStatus OrderName(FoodOrderStatus cItem, bool Status)
        {
            cItem.Status = Status;
            return cItem;
        }

        public static FoodOrderStatus CreatedDate(FoodOrderStatus cItem, DateTime CreatedDate)
        {
            cItem.CreatedDate = CreatedDate;
            return cItem;
        }

    }
}
