import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdoptionComponent } from './adoption/adoption.component';
import { DummyComponent } from './dummy/dummy.component';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LandindComponent } from './landind/landind.component';
import { NavbarComponent } from './navbar/navbar.component';

export const routes: Routes = [ 
  { path: '', component:LandindComponent,
    pathMatch: 'full'},
  { path: 'landing', component: LandindComponent },
  { path: 'signin', component:  LoginComponent  },
  { path: 'dash', component:  DashboardComponent  },
  { path: 'home', component: DummyComponent },
  { path: 'aboutus', component: DummyComponent },
  { path: 'Mascota', component: AdoptionComponent },
  { path: 'adoption', component: AdoptionComponent},
  { path: 'home', component: NavbarComponent}
]
 @NgModule({
   imports: [RouterModule.forRoot(routes)],
   exports: [RouterModule]
 })

export class AppRoutingModule { }
