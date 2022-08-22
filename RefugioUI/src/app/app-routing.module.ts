import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdoptionComponent } from './adoption/adoption.component';
import { DummyComponent } from './dummy/dummy.component';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LandindComponent } from './landind/landind.component';
import { NavbarComponent } from './navbar/navbar.component';
import { GaleryComponent } from './galery/galery.component';
import { FormSolicitudComponent } from './form-solicitud/form-solicitud.component';
import { RescateComponent } from './rescate/rescate.component';

export const routes: Routes = [
  { path: '', component: LandindComponent, pathMatch: 'full' },
  { path: 'landing', component: LandindComponent },
  { path: 'signin', component: LoginComponent },
  { path: 'dash', component: DashboardComponent },
  { path: 'home', component: DummyComponent },
  { path: 'aboutus', component: DummyComponent },
  { path: 'mascota', component: GaleryComponent },
  { path: 'adoption', component: AdoptionComponent },
  { path: 'home', component: NavbarComponent },
  { path: 'form', component: FormSolicitudComponent },
  { path: 'rescue', component: RescateComponent}
]
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
