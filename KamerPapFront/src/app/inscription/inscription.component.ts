import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-inscription',
  templateUrl: './inscription.component.html',
  styleUrls: ['./inscription.component.css']
})
export class InscriptionComponent implements OnInit {

  inscriptionForm: FormGroup;
  errorMessage: string;

  constructor(private formBuilder: FormBuilder,
    private authService: AuthService,
    private router: Router) {

  }

  ngOnInit(): void {
    this.initForm()
  }

  initForm() {
    this.inscriptionForm = this.formBuilder.group({
      nomUtilisateur: ['', [Validators.required]],
      email: ['', [Validators.required, Validators.email]],
      passWord: ['', [Validators.required, Validators.pattern(/[0-9a-zA-Z]{6,}/)]]
    });
  }

  onSubmit() {
    const nomUtilisateur = this.inscriptionForm.get('nomUtilisateur').value;
    const email = this.inscriptionForm.get('email').value;
    const passWord = this.inscriptionForm.get('passWord').value;
    this.authService.createNouveauUtilisateur(email, passWord, nomUtilisateur);
    this.router.navigate(['creerAnnonce']);
  }

  onBackToAnnonces() {
    this.initForm();
    this.router.navigate(['']);
  }

}
