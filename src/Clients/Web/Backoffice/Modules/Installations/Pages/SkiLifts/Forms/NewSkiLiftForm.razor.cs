using Microsoft.AspNetCore.Components;
using SkiResortManager.API.Shared.Modules.Installations.SkiLifts;
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
        public HttpClient HttpClient { get; set; }

        [Parameter]
        public string FormId { get; set; }

        private IEnumerable<EnumWithFriendlyString<SkiLiftType>> _skiLiftTypes = SkiLiftTypes.GetValues();

        private NewSkiLift _newSkiLift = new NewSkiLift();

        public async Task HandleValidSubmit()
        {
            var guid = await HttpClient.PostAsJsonAsync(
                SkiLiftsRoutes.Base + "/" + SkiLiftsRoutes.NewSkiLift,
                new NewSkiLiftRequest(
                    _newSkiLift.SkiLiftType,
                    _newSkiLift.Code,
                    _newSkiLift.Name,
                    _newSkiLift.Length,
                    _newSkiLift.Speed,
                    _newSkiLift.StartAltitude,
                    _newSkiLift.EndAltitude,
                    _newSkiLift.CapacityPerHour
                ));

            Console.WriteLine("Guid : " + guid.Content.ReadFromJsonAsync<Guid>().Result);
        }
    }
}
