using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Foods
{
    public class FoodBrandsEntityFactory
    {
        public static FoodBrands CreateBuilder()
        {
            return new FoodBrands();
        }

        public static FoodBrands Name(FoodBrands cItem, string Name)
        {
            cItem.Name = Name;
            return cItem;
        }

        public static FoodBrands CreatedDate(FoodBrands cItem, DateTime dateTime)
        {
            cItem.CreatedDate = dateTime;
            return cItem;
        }


        public static FoodBrands OwnerName(FoodBrands cItem, string OwnerName)
        {
            cItem.OwnerName = OwnerName;
            return cItem;
        }


        public static FoodBrands OwnerPlace(FoodBrands cItem, string OwnerPlace)
        {
            cItem.OwnerPlace = OwnerPlace;
            return cItem;
        }
    }
}
