using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Catogry
{
    public class FoodCatogryEntityFactory
    {
        public static FoodCatogryEntity Create(string Description)
        {
            return new FoodCatogryEntity(Description); ;
        }
    }
}
