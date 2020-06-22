import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-identification',
  templateUrl: './identification.component.html',
  styleUrls: ['./identification.component.css']
})
export class IdentificationComponent implements OnInit {

  identificationForm: FormGroup;
  errorMessage: string;

  constructor(private formBuilder: FormBuilder,
              private authService: AuthService,
              private router: Router) {

   }

  ngOnInit(): void {
    this.initForm()
  }

  initForm(){
    this.identificationForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      passWord: ['', [Validators.required, Validators.pattern(/[0-9a-zA-Z]{6,}/)]]
    });
  }

  onSubmit(){
    const email = this.identificationForm.get('email').value;
    const passWord = this.identificationForm.get('passWord').value;
    this.authService.identification(email, passWord);
    this.router.navigate(['creerAnnonce']);
  }

  onBackToAnnonces() {
    this.initForm();
    this.router.navigate(['']);
  }
}
