import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

export const appRoutes: Routes = [
  { path: '', redirectTo: 'intro', pathMatch: 'full' },
  { path: 'intro', loadChildren: './landing/landing.module#LandingModule' }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes, { useHash: true });