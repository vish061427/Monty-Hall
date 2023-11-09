import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GameSimulationFormComponent } from './game-simulation-form.component';

describe('GameSimulationFormComponent', () => {
  let component: GameSimulationFormComponent;
  let fixture: ComponentFixture<GameSimulationFormComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GameSimulationFormComponent]
    });
    fixture = TestBed.createComponent(GameSimulationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
