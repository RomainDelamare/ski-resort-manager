using MediatR;
using SkiResortManager.API.Shared.Modules.Installations.SkiLifts;
using SkiResortManager.API.Shared.Utils;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Requests
{
    public class NewSkiLiftRequestHandler : IRequestHandler<NewSkiLiftRequest, Guid>
    {
        private readonly HttpClient _httpClient;

        public NewSkiLiftRequestHandler(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Guid> Handle(NewSkiLiftRequest request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.PostAsJsonAsync(
                RouteBuilder.Build(SkiLiftsRoutes.Base, SkiLiftsRoutes.NewSkiLift),
                new NewSkiLift(
                    request.SkiLiftType,
                    request.Code,
                    request.Name,
                    request.Length,
                    request.Speed,
                    request.StartAltitude,
                    request.EndAltitude,
                    request.CapacityPerHour
                ));

            return response.Content.ReadFromJsonAsync<Guid>().Result;
        }
    }
}
