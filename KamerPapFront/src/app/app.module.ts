import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InscriptionComponent } from './inscription/inscription.component';
import { IdentificationComponent } from './identification/identification.component';
import { AnnoncesViewComponent } from './annonces-view/annonces-view.component';
import { Routes, RouterModule } from '@angular/router';
import { CreerAnnonceComponent } from './creer-annonce/creer-annonce.component';
import { VisualiserAnnonceComponent } from './visualiser-annonce/visualiser-annonce.component';

const appRoutes: Routes = [
  { path: 'annonces', component: AnnoncesViewComponent},
  { path: 'creerAnnonce', component: CreerAnnonceComponent},
  { path: 'visualiserAnnonce', component: VisualiserAnnonceComponent},
  { path: 'auth/identification', component: IdentificationComponent},
  { path: 'auth/inscription', component: InscriptionComponent},
  { path: '', component: AnnoncesViewComponent},
]

@NgModule({
  declarations: [
    AppComponent,
    InscriptionComponent,
    IdentificationComponent,
    AnnoncesViewComponent,
    CreerAnnonceComponent,
    VisualiserAnnonceComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
