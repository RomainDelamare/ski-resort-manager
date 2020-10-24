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
                NewSkiLift = _newSkiLift
            });

            Console.WriteLine("Guid : " + guid);
        }
    }
}
