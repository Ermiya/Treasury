import { Component, OnInit, ViewChild } from '@angular/core';
import { _HttpClient, ModalHelper } from '@delon/theme';
import { FormGroup, FormControl } from '@angular/forms';


@Component({
  selector: 'app-accounting-document-struct',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.less']
})
export class BankAcccountsMainComponent implements OnInit {

  topForm = new FormGroup({
    bank: new FormControl(),
    branch: new FormControl(),
    account_type: new FormControl(),
    account_number: new FormControl(),
    sheba_number: new FormControl(),
    cart_number: new FormControl(),
    detail_acc1: new FormControl(),
    detail_acc2: new FormControl(),
    personal1: new FormControl(),
    personal2: new FormControl(),
    opening_date: new FormControl(),
    end_date: new FormControl(),
    company_account: new FormControl(),
    status: new FormControl()
  });

  constructor() { }

  ngOnInit() { }






}
