import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import Adoption from './models/register';

@Injectable({
  providedIn: 'root'
})
export class AdoptionService {
  readonly apiURL = "https://localhost:7245/api"

  constructor(private httpClient: HttpClient) { }

 

  getUser(): Observable<Adoption[]> {

    return this.httpClient.get<Adoption[]>(this.apiURL + '/NewLogins');

  }



  addUser(user: Adoption) {

    return this.httpClient.post<Adoption>(APIURL.register, user);

  }
