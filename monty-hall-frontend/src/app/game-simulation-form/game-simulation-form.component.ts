import { Component } from '@angular/core';
import { MontyHallService } from '../monty-hall-services/monty-hall.service';

@Component({
  selector: 'app-game-simulation-form',
  templateUrl: './game-simulation-form.component.html',
  styleUrls: ['./game-simulation-form.component.css']
})
export class GameSimulationFormComponent {
  numSimulations!: number;
  changeDoor!: boolean;
  winPercentage!: number;

  constructor(private montyHallService: MontyHallService) { }

  startSimulation() {
    // Place the logic to start the simulation here
    const simulationData = {
      numberOfSimulations: this.numSimulations,
      changeDoor: this.changeDoor
  };


  
  this.montyHallService.simulateMontyHallGame(simulationData).subscribe(
    (response: any) => {
      if (response!== undefined) {
        console.log('Simulation results', response.simulations);
        this.winPercentage = response.winPercentage;
        console.log('Winning Percentage:', this.winPercentage);
      } else {
        console.error('API response is missing expected data.');
      }
    },
    (error: any) => {
      console.error('Error', error);
    }
  );
  }
}
