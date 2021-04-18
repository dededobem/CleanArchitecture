using CleanArchitecture.Infra.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkingLotController : ControllerBase
    {        

        private readonly ILogger<ParkingLotController> _logger;
        private readonly ParkingLotRepositorySql _parkingLotRepository;

        public ParkingLotController(ILogger<ParkingLotController> logger, 
            ParkingLotRepositorySql parkingLotRepository)
        {
            _logger = logger;
            _parkingLotRepository = parkingLotRepository;
        }

        [HttpGet]
        [Route("{code}")]
        public async Task<IActionResult> Get(string code) =>
            new OkObjectResult(await _parkingLotRepository.GetParkingLot(code));        
    }
}
