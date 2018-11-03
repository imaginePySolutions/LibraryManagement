import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from '../interfaces/book';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  baseUrl : string = 'api/Books';
constructor(private http : HttpClient) { }

  getBooks(){
    return this.http.get(`${this.baseUrl}`);
  }

  createBooks(book : Book){
    return this.http.post(`${this.baseUrl}`,book);

  }
}
