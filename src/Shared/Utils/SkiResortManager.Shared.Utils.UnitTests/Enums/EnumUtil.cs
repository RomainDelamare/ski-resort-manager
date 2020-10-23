using SkiResortManager.Shared.Utils.Enums;
using SkiResortManager.Shared.Utils.UnitTests.Enums.ExampleEnums;
using System.Linq;
using Xunit;

namespace SkiResortManager.Shared.Utils.UnitTests.Enums
{
    public class EnumUtil
    {
        [Fact]
        public void EnumUtil_GetValues_WithFilledEnum()
        {
            var filledEnum = Utils.Enums.EnumUtil.GetValues<FilledEnum>();
            Assert.Equal(2, filledEnum.Count());
        }

        [Fact]
        public void EnumUtil_GetValues_WithEmptyEnum()
        {
            var emptyEnum = Utils.Enums.EnumUtil.GetValues<EmptyEnum>();
            Assert.Empty(emptyEnum);
        }
    }
}
