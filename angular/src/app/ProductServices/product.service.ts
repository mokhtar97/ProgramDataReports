import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }

  getProducts(): Observable<any>{
    return this.http.get<any>('http://localhost:50670/api/products');
   }

   getPrograms(): Observable<any>{
    return this.http.get<any>('http://localhost:50670/api/applicationPrograms');
   }


   
   getReports(): Observable<any>{
    return this.http.get<any>('http://localhost:50670/api/reports');
   }

   getParameters(): Observable<any>{
    return this.http.get<any>('http://localhost:50670/api/parameters');
   }


   getViewData(pagenumber: number): Observable<any>{
    return this.http.get<any>('http://localhost:50670/api/ViewapplicationDatas?pageNumber=' + pagenumber);
   }



}
