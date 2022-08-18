import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
export const routes: Routes = [ 
  {
    path: 'signin',

    component:  LoginComponent
  },
  {
    path: 'dash',

    component:  DashboardComponent
  }
]


 @NgModule({
   imports: [RouterModule.forRoot(routes)],
   exports: [RouterModule]
 })


export class AppRoutingModule { }
