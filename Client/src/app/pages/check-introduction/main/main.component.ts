import { Component, OnInit, ViewChild } from '@angular/core';
import { _HttpClient, ModalHelper } from '@delon/theme';
import { FormGroup, FormControl } from '@angular/forms';


@Component({
  selector: 'app-accounting-document-struct',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.less']
})
export class CheckIntroductionMainComponent implements OnInit {

  topForm = new FormGroup({
    bank: new FormControl(),
    branch: new FormControl(),
    account_number: new FormControl(),
    from: new FormControl(),
    to: new FormControl(),
    check_number: new FormControl()
  });

  constructor() { }

  ngOnInit() { }






}
