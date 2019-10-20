import { Component, OnInit, ViewChild } from '@angular/core';
import { _HttpClient, ModalHelper } from '@delon/theme';
import { FormGroup, FormControl } from '@angular/forms';
import { CommonPageService } from 'src/app/_services/common-page.service';
import { CommonPageHeaders } from 'src/app/_models/common-page-headers';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-accounting-document-struct',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.less']
})
export class CommonPagesMainComponent implements OnInit {


  headers: CommonPageHeaders;
  isVisible = false;
  topForm = new FormGroup({
    temporary_doc_number: new FormControl(),
    financial_year: new FormControl(),
    status: new FormControl(),
    doc_description: new FormControl()
  });
  middleForm = new FormGroup({
    cost_in_words: new FormControl(),
    sum: new FormControl()
  });


  bottomForm = new FormGroup({

    sum2: new FormControl()
  });



  constructor(private activatedRoute: ActivatedRoute, private commonPageService: CommonPageService) {
    this.activatedRoute.params.subscribe(params => {
      this.commonPageService.getHeaders(params.id).subscribe((data: CommonPageHeaders) => {
        this.headers = data;
      });
    }, error => {
      console.log(error);
    });
  }

  ngOnInit() {


  }


  submit() {
    console.log(this.bottomForm);
  }


  showModal(): void {
    this.isVisible = true;
  }

  handleOk(): void {
    console.log('Button ok clicked!');
    this.isVisible = false;
  }

  handleCancel(): void {
    console.log('Button cancel clicked!');
    this.isVisible = false;
  }



}
