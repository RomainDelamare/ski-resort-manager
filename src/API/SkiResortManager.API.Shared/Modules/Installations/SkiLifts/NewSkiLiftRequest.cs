using SkiResortManager.Shared.Enums.Enums.Installations.SkiLifts;

namespace SkiResortManager.API.Shared.Modules.Installations.SkiLifts
{
    public record NewSkiLiftRequest(
        SkiLiftType SkiLiftType,
        string Code,
        string Name,
        int? Length,
        decimal? Speed,
        int? StartAltitude,
        int? EndAltitude,
        int? CapacityPerHour
    );
}
