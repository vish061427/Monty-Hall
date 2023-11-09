using System;
using System.Collections.Generic;
using MontyHallBackend.Models;

namespace MontyHallBackend.Services{

public class MontyHallServices{
    public (List<GameSimulation> simulations, double winPercentage )SimulateMontyHallGames(int numberOfSimulations,bool changeDoor){
        var random = new Random();
        var simulations = new List<GameSimulation>();
        int wins = 0;

        for (int i=0;i<numberOfSimulations;i++){

            int carPosition = random.Next(1,4);
            int selectedDoor = random.Next(1,4);
            int revealedDoor;

            do{
                revealedDoor = random.Next(1,4);
        } while (revealedDoor == carPosition || revealedDoor == selectedDoor);

        if(changeDoor){
            int newSelectedDoor;

            do{
                newSelectedDoor = random.Next(1,4);
            } while (newSelectedDoor == selectedDoor || newSelectedDoor == revealedDoor);

            selectedDoor = newSelectedDoor;
        }

        bool playerWins = selectedDoor == carPosition;

        if (playerWins){
            wins++;
        }


        simulations.Add(new GameSimulation(i,playerWins,carPosition,selectedDoor,revealedDoor));
        }

        double winPercentage = (double)wins / (double)numberOfSimulations * 100;

        return (simulations, winPercentage);
    }



}
}
