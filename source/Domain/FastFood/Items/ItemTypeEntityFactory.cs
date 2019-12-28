using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.Items
{
    public class ItemTypeEntityFactory
    {

        public static ItemTypeEntity CreateBuilder()
        {
            return new ItemTypeEntity();
        }

        public static ItemTypeEntity ItemKey(ItemTypeEntity cItem, string ItemKey)
        {
            cItem.ItemKey = ItemKey;
            return cItem;
        }

        public static ItemTypeEntity CreatedDate(ItemTypeEntity cItem, DateTime CreatedDate)
        {
            cItem.CreatedDate = CreatedDate;
            return cItem;
        }

    }
}
