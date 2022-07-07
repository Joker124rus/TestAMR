import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing/app-routing.module';

import { AppComponent } from './app.component';
import { RanobeComponent } from './ranobes/ranobe/ranobe.component';
import { RanobesComponent } from './ranobes/ranobes.component';
import { AdminComponent } from './admin/admin.component';
import { CreateRanobeComponent } from './admin/create-ranobe/create-ranobe.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    RanobeComponent,
    RanobesComponent,
    AdminComponent,
    CreateRanobeComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
