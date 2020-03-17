import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EntryService {
  // Base URL to use for connecting to API.
  baseUrl = 'http://localhost:5000/api/expense/';

constructor(private http: HttpClient) { }

// Connects to API and runs the HTTP Post entry method and sends the current model.
enterExpense(model: any) {
  return this.http.post(this.baseUrl + 'entry', model);
}

}
