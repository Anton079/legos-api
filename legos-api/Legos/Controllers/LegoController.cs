using Microsoft.AspNetCore.Mvc;

namespace legos_api.Legos.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LegoController
    {
        private ILegoRepo _legoRepo;

        public LegoController(ILegoRepo legoRepo)
        {
            _legoRepo = legoRepo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Lego>>> GetLegoAsync()
        {
            var lego = await _legoRepo.GetLegosAsync();

            return Ok(lego);
        }
    }
}
