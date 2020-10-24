using MediatR;
using SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Models;
using System;

namespace SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Requests
{
    public class NewSkiLiftRequest : IRequest<Guid>
    {
        public NewSkiLift NewSkiLift { get; set; }
    }
}
