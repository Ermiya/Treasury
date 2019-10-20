
// angular components
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared';
// intra components
import { DocumentStructMainComponent } from './main/main.component';

// added components
import { NzFormModule, NzInputModule } from 'ng-zorro-antd';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzGridModule } from 'ng-zorro-antd/grid';

import { NzTableModule } from 'ng-zorro-antd/table';
import { NzCheckboxModule } from 'ng-zorro-antd/checkbox';
import { DocumentStructRoutingModule } from './document-struct-routing.module';


@NgModule({
  declarations: [DocumentStructMainComponent],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    NzFormModule,
    NzInputModule,
    NzButtonModule,
    NzGridModule,
    NzTableModule,
    NzCheckboxModule,
    SharedModule,
    DocumentStructRoutingModule
  ]
})
export class DocumentStructModule { }
