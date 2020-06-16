import { Component, OnInit } from '@angular/core';
import { AnnonceService } from '../services/annonce.service';
import { Annonce } from '../models/Annonce';

@Component({
  selector: 'app-annonces-view',
  templateUrl: './annonces-view.component.html',
  styleUrls: ['./annonces-view.component.css']
})
export class AnnoncesViewComponent implements OnInit {
  annonces: Annonce[]=[];

  constructor(private annonceService: AnnonceService) { }

  ngOnInit(): void {
    this.annonces = this.annonceService.Annonces;
  }

}
