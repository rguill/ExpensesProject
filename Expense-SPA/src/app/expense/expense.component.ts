import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-expense',
  templateUrl: './expense.component.html',
  styleUrls: ['./expense.component.css']
})
export class ExpenseComponent implements OnInit {
  expenses: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getExpenses();
  }

  getExpenses() {
    this.http.get('http://localhost:5000/api/expense').subscribe(response => {
      this.expenses = response;
    }, error => {
      console.log(error);
    });
  }

}
