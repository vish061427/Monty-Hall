using System;
using System.Collections.Generic;

namespace MontyHallBackend.Models
{
    public class SimulationResponse
    {
       public List<GameSimulation>? Simulations { get; set; }
    public double WinPercentage { get; set; }
    }
}