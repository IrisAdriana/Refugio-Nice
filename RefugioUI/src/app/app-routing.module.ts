import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdoptionComponent } from './adoption/adoption.component';
import { DummyComponent } from './dummy/dummy.component';
import { CommonModule } from '@angular/common';

import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LandindComponent } from './landind/landind.component';
import { NavbarComponent } from './navbar/navbar.component';
import { GaleryComponent } from './galery/galery.component';

export const routes: Routes = [ 
  { path: '', component:LandindComponent,
    pathMatch: 'full'},
  { path: 'landing', component: LandindComponent },
  { path: 'signin', component:  LoginComponent  },
  { path: 'dash', component:  DashboardComponent  },
  { path: 'home', component: DummyComponent },
  { path: 'aboutus', component: DummyComponent },
  { path: 'mascota', component: GaleryComponent },
  { path: 'adoption', component: AdoptionComponent},
  { path: 'home', component: NavbarComponent}
]
 @NgModule({
   imports: [RouterModule.forRoot(routes)],
   exports: [RouterModule]
 })



import { RouterModule, Routes } from '@angular/router';


export const routes: Routes = []

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
>>>>>>> 2af10e347012c04d43593c9130c8e7fc6d33e637
export class AppRoutingModule { }
