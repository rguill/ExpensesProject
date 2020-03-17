import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-expenses',
  templateUrl: './expenses.component.html',
  styleUrls: ['./expenses.component.css']
})
export class ExpensesComponent implements OnInit {
  expenses: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getExpenses();
  }

  // Connects to the API and runs the HTTP Get method to return the list of expenses.
  getExpenses() {
    this.http.get('http://localhost:5000/api/expense/').subscribe(response => {
      this.expenses = response;
    }, error => {
      console.log(error);
    });
  }

}
