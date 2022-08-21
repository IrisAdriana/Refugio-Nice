import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import User from '../../models/user';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class LoginService {
  readonly apiURL = "http://localhost:5149/Cuenta"
  constructor(private httpClient: HttpClient) { }

  getUser(cuenta: string, pwd: string): Observable<User[]> {
    //return this.httpClient.get<User[]>(this.apiURL );

    // let usertmp = {
    //   cuenta: "usuario1",
    //   pwd: "123"
    // }
    // console.log(usertmp);
    //return this.httpClient.post<User[]>(this.apiURL, usertmp);
    return this.httpClient.get<User[]>(this.apiURL+'?'+'cuenta'+'='+cuenta+'&'+'pwd'+pwd);
  }

  addUser(user: User) {

    return this.httpClient.post<User>(this.apiURL, user);

  }

}

