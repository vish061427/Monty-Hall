import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GameSimulationFormComponent } from './game-simulation-form/game-simulation-form.component';

const routes: Routes = [
  { path: '',component: GameSimulationFormComponent}, // Home page route
  // Other routes
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
