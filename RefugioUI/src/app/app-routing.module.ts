import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdoptionComponent } from './adoption/adoption.component';
import { DummyComponent } from './dummy/dummy.component';
import { CommonModule } from '@angular/common';

const routes: Routes = [
  { path: 'home', component: DummyComponent },
  { path: 'aboutus', component: DummyComponent },
  { path: 'Mascota', component: AdoptionComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
