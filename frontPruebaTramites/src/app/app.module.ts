import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WelcomeComponent } from './Componente/welcome/welcome.component';
import { LoginComponent } from './Componente/login/login.component';
import { ErrorComponent } from './Componente/error/error.component';
import { MenuComponent } from './Componente/menu/menu.component';
import { FooterComponent } from './Componente/footer/footer.component';
import { TramiteComponent } from './Componente/tramite/tramite.component';
import { TramiteService } from './Servicio/tramite.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    LoginComponent,
    ErrorComponent,
    MenuComponent,
    FooterComponent,
    TramiteComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [TramiteService],
  bootstrap: [AppComponent]
})
export class AppModule { }
