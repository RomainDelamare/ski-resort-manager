using Microsoft.AspNetCore.Components;
using SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Models;
using SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Services;
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
        public INewSkiLiftService newSkiLiftService { get; set; }

        [Inject]
        public LockPageEvent LockPageEvent { get; set; }

        [Parameter]
        public string FormId { get; set; }

        private IEnumerable<EnumWithFriendlyString<SkiLiftType>> _skiLiftTypes = SkiLiftTypes.GetValues();

        private NewSkiLift _newSkiLift = new NewSkiLift();

        public async Task HandleValidSubmit()
        {
            LockPageEvent.LockPage();

            var guid = await newSkiLiftService.NewSkiLift(_newSkiLift);

            LockPageEvent.UnlockPage();

            Console.WriteLine("Guid : " + guid);
        }
    }
}
