using MediatR;
using SkiResortManager.Shared.Enums.Enums.Installations.SkiLifts;
using System;

namespace SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Requests
{
    public class NewSkiLiftRequest : IRequest<Guid>
    {
        public SkiLiftType SkiLiftType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Length { get; set; }
        public decimal? Speed { get; set; }
        public int? StartAltitude { get; set; }
        public int? EndAltitude { get; set; }
        public int? CapacityPerHour { get; set; }
    }
}
