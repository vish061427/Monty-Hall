using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MontyHallBackend.Models
{
    public class SimulationRequest
    {
        public int NumberOfSimulations { get; set; }
        public bool ChangeDoor { get; set; }
    }
}