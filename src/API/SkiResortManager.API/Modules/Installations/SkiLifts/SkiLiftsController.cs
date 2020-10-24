using Microsoft.AspNetCore.Mvc;
using SkiResortManager.API.Shared.Modules.Installations.SkiLifts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SkiResortManager.API.Modules.Installations.SkiLifts
{
    [Route(SkiLiftsRoutes.Base)]
    [ApiController]
    public class SkiLiftsController : ControllerBase
    {
        [HttpPost(SkiLiftsRoutes.NewSkiLift)]
        public async Task<IActionResult> NewSkiLift([FromBody] NewSkiLiftRequest request)
        {
            await Task.Run(() => { Thread.Sleep(2000); });
            var guid = Guid.NewGuid();
            return Ok(guid);
        }
    }
}
