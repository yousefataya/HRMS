using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.HistoryOrders
{
    public class FoodOrderHistoryEntityFactory
    {

        public static FoodOrderHistory CreateBuilder()
        {
            return new FoodOrderHistory();
        }


        public static FoodOrderHistory Name(FoodOrderHistory cItem, bool IsExpired)
        {
            cItem.IsExpired = IsExpired;
            return cItem;
        }

        public static FoodOrderHistory ExpiredDate(FoodOrderHistory cItem, DateTime ExpiredDate)
        {
            cItem.ExpiredDate = ExpiredDate;
            return cItem;
        }


        public static FoodOrderHistory CreatedDate(FoodOrderHistory cItem, DateTime CreatedDate)
        {
            cItem.CreatedDate = CreatedDate;
            return cItem;
        }


    }
}
