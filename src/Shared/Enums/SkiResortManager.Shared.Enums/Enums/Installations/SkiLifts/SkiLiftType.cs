using SkiResortManager.Shared.Enums.Exceptions;
using SkiResortManager.Shared.Utils.Enums;
using System.Collections.Generic;
using System.Linq;

namespace SkiResortManager.Shared.Enums.Enums.Installations.SkiLifts
{
    public enum SkiLiftType
    {
        DragLift = 1,
        ChairLift = 2,
        GondolaLift = 3,
        TBarLift = 4,
        MagicCarpet = 5,
        RopeTow = 6,
        Funicular = 7
    }

    public static class SkiLiftTypeExtension
    {
        public static string ToFriendlyString(this SkiLiftType skiLiftType) =>
            skiLiftType switch
            {
                SkiLiftType.DragLift => "Drag lift",
                SkiLiftType.ChairLift => "Chair lift",
                SkiLiftType.GondolaLift => "Gondola lift",
                SkiLiftType.TBarLift => "T bar lift",
                SkiLiftType.MagicCarpet => "Magic carpet",
                SkiLiftType.RopeTow => "Rope tow",
                SkiLiftType.Funicular => "Funicular",
                _ => throw new InvalidEnumArgumentException<SkiLiftType>(skiLiftType)
            };
    }

    public static class SkiLiftTypes
    {
        public static IEnumerable<EnumWithFriendlyString<SkiLiftType>> GetValues() =>
            EnumUtil.GetValues<SkiLiftType>()
                .Select(t => new EnumWithFriendlyString<SkiLiftType>(t, t.ToFriendlyString()));
    }
}
