using Microsoft.AspNetCore.Mvc;
using MontyHallBackend.Services;
using MontyHallBackend.Models;
using System;
using System.Collections.Generic;

namespace MontyHallBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MontyHallController : ControllerBase
    {
        private readonly MontyHallServices _montyHallServices;
        public MontyHallController(MontyHallServices montyHallServices)
        {
            _montyHallServices = montyHallServices;
        }


        [HttpPost]
        [Route("SimulateMontyHallGames")]
        public ActionResult<(List<GameSimulation>simulations, double winPercentage)> SimulateMontyHallGames([FromBody] SimulationRequest request)
        {
            try
            {
                var (simulations, winPercentage) = _montyHallServices.SimulateMontyHallGames(request.NumberOfSimulations, request.ChangeDoor);
                
                Console.WriteLine($"Winning Percentage: {winPercentage}%");

                var response = new SimulationResponse
                {
                    Simulations = simulations,
                    WinPercentage = winPercentage
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}