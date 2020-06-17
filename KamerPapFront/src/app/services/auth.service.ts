import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor() { }

  createNouveauUtilisateur(email: string, passWord: string, NomUtilisateur: string){
    return true;
  }

  identification(identifiant: string, passWord: string){

  }

  deconnexion(){

  }
}
