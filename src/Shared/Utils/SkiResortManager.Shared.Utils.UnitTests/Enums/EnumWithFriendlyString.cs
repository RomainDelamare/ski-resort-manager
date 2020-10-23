using SkiResortManager.Shared.Utils.Enums;
using SkiResortManager.Shared.Utils.UnitTests.Enums.ExampleEnums;
using System;
using Xunit;

namespace SkiResortManager.Shared.Utils.UnitTests.Enums
{
    public class EnumWithFriendlyString
    {
        [Fact]
        public void EnumWithFriendlyString_ctor_ValidParameters()
        {
            var enumWithFriendlyString = new EnumWithFriendlyString<FilledEnum>(FilledEnum.Item1, "Item 1");
            Assert.Equal(FilledEnum.Item1, enumWithFriendlyString.EnumValue);
            Assert.Equal("Item 1", enumWithFriendlyString.FriendlyString);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void EnumWithFriendlyString_ctor_NullOrEmptyParameters(string friendlyString)
        {
            Assert.Throws<ArgumentException>(() => new EnumWithFriendlyString<FilledEnum>(FilledEnum.Item1, friendlyString));
        }
    }
}
