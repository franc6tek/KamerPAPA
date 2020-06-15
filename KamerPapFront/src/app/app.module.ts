import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InscriptionComponent } from './inscription/inscription.component';
import { IdentificationComponent } from './identification/identification.component';
import { AnnoncesViewComponent } from './annonces-view/annonces-view.component';

@NgModule({
  declarations: [
    AppComponent,
    InscriptionComponent,
    IdentificationComponent,
    AnnoncesViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
