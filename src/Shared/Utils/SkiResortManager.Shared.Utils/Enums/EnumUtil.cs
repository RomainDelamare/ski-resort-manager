using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiResortManager.Shared.Utils.Enums
{
    public static class EnumUtil
    {
        public static IEnumerable<TEnum> GetValues<TEnum>()
            where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
        }
    }
}
