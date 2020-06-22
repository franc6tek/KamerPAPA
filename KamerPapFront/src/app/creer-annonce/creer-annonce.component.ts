import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';
import { AnnonceService } from '../services/annonce.service';
import { Annonce } from '../models/Annonce';

@Component({
  selector: 'app-creer-annonce',
  templateUrl: './creer-annonce.component.html',
  styleUrls: ['./creer-annonce.component.css']
})
export class CreerAnnonceComponent implements OnInit {

  creerAnnonceForm: FormGroup;
  errorMessage: string;
  annonce: Annonce;

  constructor(private formBuilder: FormBuilder,
              private authService: AuthService,
              private annonceService: AnnonceService,
              private router: Router) {

   }

  ngOnInit(): void {
    this.initForm()
  }

  initForm(){
    this.creerAnnonceForm = this.formBuilder.group({
      titre: ['',[Validators.required]],
      description: ['', [Validators.required]],
      ville: ['', [Validators.required]],
      prix: ['', [Validators.required]],
    });
  }

  onSubmit(){
    const titre = this.creerAnnonceForm.get('titre').value;
    const description = this.creerAnnonceForm.get('description').value;
    const ville = this.creerAnnonceForm.get('ville').value;
    const prix = this.creerAnnonceForm.get('prix').value;

    this.annonce  = {
      AnnonceId: 1,
      Titre: titre,
      Description: description,
      DateCreation: new Date(),
      Prix: prix,
      Ville: ville,
      Telephone: '',
    };
    this.annonceService.Annonces.push(this.annonce);
    this.router.navigate(['annonces']);
  }

  onBackToAnnonces() {
    this.initForm();
    this.router.navigate(['']);
  }

}
