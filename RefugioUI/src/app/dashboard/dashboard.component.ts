import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import Adoption from '../models/adoption';
import { AdoptionService } from '../services/adoption.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  pets$:Observable<Adoption[]> | undefined;
  constructor(private mascota:AdoptionService) { }

  ngOnInit(): void {
    this.get();

  }
  get():void{
    this.pets$ = this.mascota.getPet();
    console.log("API mascotas")
    console.log(this.pets$)
  }


}
