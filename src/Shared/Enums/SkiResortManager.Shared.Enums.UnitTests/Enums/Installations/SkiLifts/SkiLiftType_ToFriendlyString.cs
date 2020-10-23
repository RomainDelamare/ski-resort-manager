using SkiResortManager.Shared.Enums.Enums.Installations.SkiLifts;
using SkiResortManager.Shared.Enums.Exceptions;
using Xunit;

namespace SkiResortManager.Shared.Enums.UnitTests.Enums.Installations.SkiLifts
{
    public class SkiLiftType_ToFriendlyString
    {
        [Theory]
        [InlineData("Drag lift", SkiLiftType.DragLift)]
        [InlineData("Chair lift", SkiLiftType.ChairLift)]
        [InlineData("Gondola lift", SkiLiftType.GondolaLift)]
        [InlineData("T bar lift", SkiLiftType.TBarLift)]
        [InlineData("Magic carpet", SkiLiftType.MagicCarpet)]
        [InlineData("Rope tow", SkiLiftType.RopeTow)]
        [InlineData("Funicular", SkiLiftType.Funicular)]
        public void SkiLiftType_ToFriendlyString_ValidEnum(string expectedString, SkiLiftType skiLiftType)
        {
            Assert.Equal(expectedString, skiLiftType.ToFriendlyString());
        }

        [Fact]
        public void SkiLiftType_ToFriendlyString_InvalidEnum()
        {
            SkiLiftType skiLiftType = (SkiLiftType)(-1);
            Assert.Throws<InvalidEnumArgumentException<SkiLiftType>>(() => skiLiftType.ToFriendlyString());
        }
    }
}
