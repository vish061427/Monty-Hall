import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms'; // <-- NgModel lives here (for two-way binding)
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GameSimulationFormComponent } from './game-simulation-form/game-simulation-form.component';
import { GameResultsComponent } from './game-results/game-results.component';
import {HttpClientModule} from '@angular/common/http';
@NgModule({
  declarations: [
    AppComponent,
    GameSimulationFormComponent,
    GameResultsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
