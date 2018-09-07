import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  baseUrl : string = 'api/Books';
constructor(private http : HttpClient) { }

  getBooks(){
    return this.http.get(`${this.baseUrl}`);
  }
}
