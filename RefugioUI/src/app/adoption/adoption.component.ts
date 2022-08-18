import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import Adoption from '../models/adoption';
import { AdoptionService } from '../services/adoption.service';

@Component({
  selector: 'app-adoption',
  templateUrl: './adoption.component.html',
  styleUrls: ['./adoption.component.css']
})
export class AdoptionComponent implements OnInit {

  pets$:Observable<Adoption[]> | undefined;
  constructor(private service: AdoptionService, private router : Router) { }

  ngOnInit(): void {
    this.pets$ = this.service.getPet(); 
    console.log("Liris");
  }

}
