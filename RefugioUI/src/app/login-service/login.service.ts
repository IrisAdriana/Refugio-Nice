import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import User from '../models/user';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class LoginService {
  readonly apiURL = "http://localhost:5149/Cuenta?cuenta=Usuario1&pwd=123"
  constructor(private httpClient: HttpClient) { }

  getUser(): Observable<User[]> {
    return this.httpClient.get<User[]>(this.apiURL );
  }
}

