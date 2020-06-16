import { Injectable } from '@angular/core';
import { Annonce } from '../models/Annonce';

@Injectable({
  providedIn: 'root'
})
export class AnnonceService {

  Annonces: Annonce[]=[
    {
      AnnonceId: 1, 
      Titre: 'Télévision',
      Description: 'Télévision en tres bon état, avec tous les accessoirs',
      DateCreation: new Date(),
      Prix: 500,
      Ville: 'Le Blanc-Mesnil',
      Telephone: '06060606',  
    },
    {
      AnnonceId: 1, 
      Titre: 'Télévision',
      Description: 'Télévision en tres bon état, avec tous les accessoirs',
      DateCreation: new Date(),
      Prix: 500,
      Ville: 'Le Blanc-Mesnil',
      Telephone: '06060606',  
    },
  ];

  constructor() { }
}
