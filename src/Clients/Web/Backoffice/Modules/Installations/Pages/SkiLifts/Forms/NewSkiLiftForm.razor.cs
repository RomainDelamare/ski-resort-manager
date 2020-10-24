using Microsoft.AspNetCore.Components;
using SkiResortManager.API.Shared.Modules.Installations.SkiLifts;
using SkiResortManager.API.Shared.Utils;
using SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Models;
using SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Services;
using SkiResortManager.Shared.Enums.Enums.Installations.SkiLifts;
using SkiResortManager.Shared.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms
{
    public partial class NewSkiLiftForm
    {
        [Inject]
        public INewSkiLiftService newSkiLiftService { get; set; }

        [Parameter]
        public string FormId { get; set; }

        private IEnumerable<EnumWithFriendlyString<SkiLiftType>> _skiLiftTypes = SkiLiftTypes.GetValues();

        private NewSkiLift _newSkiLift = new NewSkiLift();

        public async Task HandleValidSubmit()
        {
            var guid = await newSkiLiftService.NewSkiLift(_newSkiLift);

            Console.WriteLine("Guid : " + guid);
        }
    }
}
