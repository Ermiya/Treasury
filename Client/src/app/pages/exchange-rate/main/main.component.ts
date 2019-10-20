import { Component, OnInit, ViewChild } from '@angular/core';
import { _HttpClient, ModalHelper } from '@delon/theme';
import { FormGroup, FormControl } from '@angular/forms';


@Component({
  selector: 'app-accounting-document-struct',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.less']
})
export class ExchangeRateMainComponent implements OnInit {

  bottomForm = new FormGroup({
    helper_description: new FormControl(),
    detailed_description: new FormControl(),
    detailed_side_description: new FormControl(),
    from_datetime: new FormControl(),
    to_datetime: new FormControl()
  });

  constructor() { }

  ngOnInit() { }


  submit() {
    console.log(this.bottomForm);
  }



}
