using System;
using System.ComponentModel;

namespace SkiResortManager.Shared.Enums.Exceptions
{
    public class InvalidEnumArgumentException<TEnum> : InvalidEnumArgumentException
        where TEnum : Enum
    {
        public InvalidEnumArgumentException(TEnum invalidValue)
            : base(nameof(invalidValue), Convert.ToInt32(invalidValue), typeof(TEnum))
        {

        }
    }
}
