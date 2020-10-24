using SkiResortManager.API.Shared.Modules.Installations.SkiLifts;
using SkiResortManager.API.Shared.Utils;
using SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Services
{
    public interface INewSkiLiftService
    {
        public Task<Guid> NewSkiLift(NewSkiLift newSkiLift);
    }

    public class NewSkiLiftService : INewSkiLiftService
    {
        private readonly HttpClient _httpClient;

        public NewSkiLiftService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Guid> NewSkiLift(NewSkiLift newSkiLift)
        {
            var response = await _httpClient.PostAsJsonAsync(
                RouteBuilder.Build(SkiLiftsRoutes.Base, SkiLiftsRoutes.NewSkiLift),
                new NewSkiLiftRequest(
                    newSkiLift.SkiLiftType,
                    newSkiLift.Code,
                    newSkiLift.Name,
                    newSkiLift.Length,
                    newSkiLift.Speed,
                    newSkiLift.StartAltitude,
                    newSkiLift.EndAltitude,
                    newSkiLift.CapacityPerHour
                ));

            return response.Content.ReadFromJsonAsync<Guid>().Result;
        }
    }
}
