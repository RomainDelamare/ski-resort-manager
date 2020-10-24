using MediatR;
using Microsoft.AspNetCore.Components;
using SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Models;
using SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Requests;
using SkiResortManager.Backoffice.Shared.Events;
using SkiResortManager.Shared.Enums.Enums.Installations.SkiLifts;
using SkiResortManager.Shared.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms
{
    public partial class NewSkiLiftForm
    {
        [Inject]
        public LockPageEvent LockPageEvent { get; set; }

        [Inject]
        public IMediator Mediator { get; set; }

        [Parameter]
        public string FormId { get; set; }

        private IEnumerable<EnumWithFriendlyString<SkiLiftType>> _skiLiftTypes = SkiLiftTypes.GetValues();

        private NewSkiLift _newSkiLift = new NewSkiLift();

        public async Task HandleValidSubmit()
        {
            var guid = await Mediator.Send(new NewSkiLiftRequest()
            {
                SkiLiftType = _newSkiLift.SkiLiftType,
                Code = _newSkiLift.Code,
                Name = _newSkiLift.Name,
                Length = _newSkiLift.Length,
                Speed = _newSkiLift.Speed,
                StartAltitude = _newSkiLift.StartAltitude,
                EndAltitude = _newSkiLift.EndAltitude,
                CapacityPerHour = _newSkiLift.CapacityPerHour,
            });

            Console.WriteLine("Guid : " + guid);
        }
    }
}
