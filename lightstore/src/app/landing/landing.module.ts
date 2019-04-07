import { NgModule, ModuleWithProviders } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';
import { LandingComponent } from './landing.component';

export const routes: Routes = [
  { path: '', component: LandingComponent }
]

export const routing: ModuleWithProviders = RouterModule.forChild(routes);

@NgModule({
  imports: [
    // app
    routing,

    FormsModule,
    CommonModule
  ],
  declarations: [
    LandingComponent
  ],
  entryComponents: [],

})
export class LandingModule { }
