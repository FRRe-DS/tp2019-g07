import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { ErrorComponent } from './error/error.component';
import { ListaTramiteComponent } from './lista-tramite/lista-tramite.component';
import { TramiteComponent } from './tramite/tramite/tramite.component';


// welcome
const routes: Routes = [
  { path: '', component: LoginComponent},
  { path: 'login', component: LoginComponent},
  { path: 'welcome/:nombre', component: WelcomeComponent},
  { path: 'tramites', component: ListaTramiteComponent},
  { path: 'mistramites', component: TramiteComponent},

  { path: '**', component: ErrorComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
