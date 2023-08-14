import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

// every ang app has this @ decorator and responsible for loading the angular application
@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  // Appcomponent is the entry point of app, and displaying component
  bootstrap: [AppComponent]
})
export class AppModule { }
