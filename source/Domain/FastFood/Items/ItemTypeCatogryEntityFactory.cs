using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Items
{
    public class ItemTypeCatogryEntityFactory
    {


        public static ItemTypeCatogry CreateBuilder()
        {
            return new ItemTypeCatogry();
        }


        public static ItemTypeCatogry CatogryKey(ItemTypeCatogry cItem, string CatogryKey)
        {
            cItem.CatogryKey = CatogryKey;
            return cItem;
        }

        public static ItemTypeCatogry CatogryDescription(ItemTypeCatogry cItem, string CatogryDescription)
        {
            cItem.CatogryDescription = CatogryDescription;
            return cItem;
        }
    }
}
