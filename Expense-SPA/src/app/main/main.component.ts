import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { EntryService } from '../_services/entry.service';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { BsDatepickerConfig } from 'ngx-bootstrap/datepicker/public_api';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {
  // Emitter to return to parent.
  @Output() viewExpense = new EventEmitter();
  model: any = {};
  entryForm: FormGroup;
  bsConfig: Partial<BsDatepickerConfig>;

  // Inject service to connect to API.
  constructor(private entryService: EntryService, private fb: FormBuilder) { }

  ngOnInit() {
    this.bsConfig = {
      containerClass: 'theme-dark-blue'
    }
    this.createEntryForm();
  }

  createEntryForm() {
    this.entryForm = this.fb.group({
      name: ['', Validators.required],
      date: [null, Validators.required],
      amount: ['', Validators.required],
      description: ['', Validators.required]
    });
  }

  // Entry method uses the EntryService to send the model built from the HTTP side of Main to the API.
  entry() {
    if (this.entryForm.valid) {
      this.model = Object.assign({}, this.entryForm.value);
      this.entryService.enterExpense(this.model).subscribe(() => {
        console.log('Entry successful!');
      }, error => {
        console.log(error);
      })
    }
  }

  // Method used for switching the viewMode variable to true.
  view() {
    this.viewExpense.emit(true);
    console.log('Viewing...');
  }

}
