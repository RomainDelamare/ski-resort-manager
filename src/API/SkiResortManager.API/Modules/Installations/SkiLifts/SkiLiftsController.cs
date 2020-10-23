using Microsoft.AspNetCore.Mvc;
using SkiResortManager.API.Shared.Modules.Installations.SkiLifts;
using System;
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
            await Task.Run(() => { });
            var guid = Guid.NewGuid();
            return Ok(guid);
        }
    }
}
