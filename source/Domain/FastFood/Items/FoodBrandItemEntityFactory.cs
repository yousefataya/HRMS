using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Items
{
    public class FoodBrandItemEntityFactory
    {

        public static FoodBrandItems CreateBuilder()
        {
            return new FoodBrandItems();
        }


        public static FoodBrandItems Name(FoodBrandItems cItem, string ItemName)
        {
            cItem.ItemName = ItemName;
            return cItem;
        }


        public static FoodBrandItems ItemType(FoodBrandItems cItem, string ItemType)
        {
            cItem.ItemType = ItemType;
            return cItem;
        }


        public static FoodBrandItems CreatedDate(FoodBrandItems cItem, DateTime CreatedDate)
        {
            cItem.CreatedDate = CreatedDate;
            return cItem;
        }



        /*public static FoodBrandItems Name(FoodBrandItems cItem, string ItemName)
        {
            cItem.ItemName = ItemName;
            return cItem;
        }



        public static FoodBrandItems Name(FoodBrandItems cItem, string ItemName)
        {
            cItem.ItemName = ItemName;
            return cItem;
        }*/


    }
}
