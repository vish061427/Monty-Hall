using System;

namespace MontyHallBackend.Models{
public class GameSimulation{
    public int SimulationId { get; set; }
    public bool PlayerWins { get; set; }
    public int CarPosition { get; set; }
    public int SelectedDoor { get; set; }
    public int RevealedDoor { get; set; }

    public GameSimulation(int simulationId, bool playerWins, int carPosition, int selectedDoor, int revealedDoor){
        SimulationId = simulationId;
        PlayerWins = playerWins;
        CarPosition = carPosition;
        SelectedDoor = selectedDoor;
        RevealedDoor = revealedDoor;
    }
}
}