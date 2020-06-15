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

const appRoutes: Routes = [
  { path: 'annonces', component: AnnoncesViewComponent},
  { path: 'auth/identification', component: IdentificationComponent},
  { path: 'auth/inscription', component: InscriptionComponent},
  { path: '', component: AnnoncesViewComponent},
]

@NgModule({
  declarations: [
    AppComponent,
    InscriptionComponent,
    IdentificationComponent,
    AnnoncesViewComponent
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
