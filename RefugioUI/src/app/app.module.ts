import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { NavbarComponent } from './navbar/navbar.component';
import { DummyComponent } from './dummy/dummy.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AdoptionComponent } from './adoption/adoption.component';
import { HttpClientModule } from '@angular/common/http';
import { LandindComponent } from './landind/landind.component';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FormSolicitudComponent } from './form-solicitud/form-solicitud.component';
import { GaleryComponent } from './galery/galery.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
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
    LandindComponent,
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
