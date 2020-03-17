import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-view-expense',
  templateUrl: './viewExpense.component.html',
  styleUrls: ['./viewExpense.component.css']
})
export class ViewExpenseComponent implements OnInit {
  viewMode = false;

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  // View toggle changes viewMode to false when the back button is clicked.
  viewToggle() {
    this.viewMode = false;
  }

  // Method changes the viewMode to the boolean value it was sent. Change occurs in Main.
  cancelViewMode(viewMode: boolean) {
    this.viewMode = viewMode;
  }

}
