import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpParams } from '@angular/common/http';
import { CommonPageHeaders } from '../_models/common-page-headers';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CommonPageService {
  url = "https://localhost:44352/api/GetHeaders/";
  url2 = "http://localhost:10001/api/GetHeaders/";
  url3 = "http://192.168.4.10:10001/api/GetHeaders/";
  constructor(private http: HttpClient, private router: Router) {


  }

  getHeaders(id: number): Observable<CommonPageHeaders> {
    return this.http.get<CommonPageHeaders>(this.url3 + id);
  }
}
