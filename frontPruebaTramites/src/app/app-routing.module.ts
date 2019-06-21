import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './Componente/login/login.component';
import { WelcomeComponent } from './Componente/welcome/welcome.component';
import { ErrorComponent } from './Componente/error/error.component';
import { ListaTramiteComponent } from './Componente/lista-tramite/lista-tramite.component';
import { TramiteComponent } from './Componente/tramite/tramite.component';


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
