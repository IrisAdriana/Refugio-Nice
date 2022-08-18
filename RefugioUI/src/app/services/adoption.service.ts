import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Adoption from '../models/adoption';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class AdoptionService {
  user!: Adoption
  readonly apiUrlVer= "http://localhost:5149"

  constructor(private httpClient: HttpClient) { }
  getPet(): Observable<Adoption[]> {
    return this.httpClient.get<Adoption[]>(this.apiUrlVer + '/Mascota');
  }
}
