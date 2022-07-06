import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RanobesComponent } from '../ranobes/ranobes.component';
import { RanobeComponent } from '../ranobes/ranobe/ranobe.component';

const routes: Routes = [
  { path: '', component: RanobesComponent },
  { path: 'ranobes/:id', component: RanobeComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
