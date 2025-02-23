using legos_api.Legos.Dtos;
using legos_api.Legos.Model1;
using legos_api.Legos.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace legos_api.Legos.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LegoController : ControllerBase
    {
        private ILegoRepo _legoRepo;

        public LegoController(ILegoRepo legoRepo)
        {
            _legoRepo = legoRepo;
        }

        [HttpGet("getAll")]

        public async Task<ActionResult<List<Lego>>> GetLegoAsync()
        {
            var legos = await _legoRepo.GetLegosAsync();

            return Ok(legos);
        }

        [HttpPost("add")]

        public async Task<ActionResult<LegoResponse>> CreateAsync([FromBody]LegoRequest legoReq)
        {
            LegoResponse legoSaved = await _legoRepo.CreateLegoAsync(legoReq);

            return Ok(legoSaved);
        }
    }
}
