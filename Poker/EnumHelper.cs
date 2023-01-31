using Poker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public static class EnumHelper<T>
    {
        public static int GetEnumQuantity(Type enumType )
        {
            int number = GetIntFromEnums(enumType);
            return number;
        }
        public static int GetIntFromEnums(Type enumType)
        {
            string[] enumValues = Enum.GetNames(enumType);
            return enumValues.Length;
        }
        public static T GetRanksByIndex(int enumIndex)
        {   
                T card = (T)Enum.GetValues(typeof(T)).GetValue(enumIndex);
                return card;
        }
    }
}
