import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
// inject service to components, centralizes http req, init app and init services (it is singleton), and destroyed after closing the browser
// service is availble during the lifetime of application
export class AccountService {
  baseUrl = 'https://localhost:5001/api/'

  constructor(private http: HttpClient) { }

  login(model: any) {
    return this.http.post(this.baseUrl + 'account/login', model)
  }
}