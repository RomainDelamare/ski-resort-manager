using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortManager.Shared.Utils.Enums
{
    public record EnumWithFriendlyString<T>
        where T : Enum
    {
        public T EnumValue { get; init; }
        public string FriendlyString { get; init; }

        public EnumWithFriendlyString(T enumValue, string friendlyString)
        {
            if (string.IsNullOrWhiteSpace(friendlyString))
                throw new ArgumentException();

            (EnumValue, FriendlyString) = (enumValue, friendlyString);
        }
    }
}
