import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { LandindComponent } from './landind/landind.component';

import { LoginComponent } from './login/login.component';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { DashboardComponent } from './dashboard/dashboard.component';


import { NavbarComponent } from './navbar/navbar.component';
import { DummyComponent } from './dummy/dummy.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AdoptionComponent } from './adoption/adoption.component';

import { LandindComponent } from './landind/landind.component';


import { FormSolicitudComponent } from './form-solicitud/form-solicitud.component';
import { GaleryComponent } from './galery/galery.component';


@NgModule({
  declarations: [
    AppComponent,
<<<<<<< HEAD

    LoginComponent,
    DashboardComponent,
    NavbarComponent,
    DummyComponent,
    AdoptionComponent,
    LandindComponent,
    LoginComponent,
    DashboardComponent,
    FormSolicitudComponent,
    GaleryComponent,

=======
    LandindComponent
>>>>>>> 2af10e347012c04d43593c9130c8e7fc6d33e637
  ],
  
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,

    AppRoutingModule, 
    HttpClientModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
