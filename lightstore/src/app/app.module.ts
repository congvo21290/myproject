import { BrowserModule } from '@angular/platform-browser';
import { SimpleNotificationsModule } from 'angular2-notifications';
import { NgModule } from '@angular/core';
import { routing } from "./app.routing";
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AuthModule } from './auth/auth.module';
import { LayoutModule } from './theme/layouts/layout.module';
import { ScriptLoaderService } from './_services/script-loader.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    routing,
    BrowserModule,
    BrowserAnimationsModule,
    LayoutModule,
    AuthModule,
    SimpleNotificationsModule.forRoot(),
  ],
  providers: [
    ScriptLoaderService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
