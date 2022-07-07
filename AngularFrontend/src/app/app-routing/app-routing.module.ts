import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RanobesComponent } from '../ranobes/ranobes.component';
import { RanobeComponent } from '../ranobes/ranobe/ranobe.component';
import { AdminComponent } from '../admin/admin.component';
import { CreateRanobeComponent } from '../admin/create-ranobe/create-ranobe.component';

const routes: Routes = [
  { path: '', component: RanobesComponent },
  { path: 'ranobes/:id', component: RanobeComponent },
  { path: 'admin', component: AdminComponent },
  { path: 'admin/createRanobe', component: CreateRanobeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
