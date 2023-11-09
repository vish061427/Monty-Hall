import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MontyHallService {
  private baseUrl = 'http://localhost:5020';

  getBaseUrl(): string {
    return this.baseUrl;
  }


  constructor(private http: HttpClient) { }

  simulateMontyHallGame(simulationData: any): Observable<any> {
    const url = `${this.baseUrl}/api/MontyHall/SimulateMontyHallGames`;
    return this.http.post(url, simulationData);
  }
}
