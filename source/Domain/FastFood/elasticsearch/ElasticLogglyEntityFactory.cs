using DotNetCoreArchitecture.Domain.FastFood.Catogry;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain.FastFood.elasticsearch
{
    public class ElasticLogglyEntityFactory
    {

        public static ElasticLoggly CreateBuilder()
        {
            return new ElasticLoggly();
        }

        public static ElasticLoggly LogText(ElasticLoggly cItem, string LogText)
        {
            cItem.LogText = LogText;
            return cItem;
        }

        public static ElasticLoggly MethodName(ElasticLoggly cItem, string MethodName)
        {
            cItem.MethodName = MethodName;
            return cItem;
        }

        public static ElasticLoggly ClazzName(ElasticLoggly cItem, string ClazzName)
        {
            cItem.ClazzName = ClazzName;
            return cItem;
        }

        public static ElasticLoggly FoodEntityLogText(ElasticLoggly cItem, bool FoodEntityLogText)
        {
            cItem.FoodEntityLogText = FoodEntityLogText;
            return cItem;
        }


        public static ElasticLoggly FoodOrderLogText(ElasticLoggly cItem, bool FoodEntityLogText)
        {
            cItem.FoodOrderLogText = FoodEntityLogText;
            return cItem;
        }


    }
}
