import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing/app-routing.module';

import { AppComponent } from './app.component';
import { RanobeComponent } from './ranobes/ranobe/ranobe.component';
import { RanobesComponent } from './ranobes/ranobes.component';

@NgModule({
  declarations: [
    AppComponent,
    RanobeComponent,
    RanobesComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
