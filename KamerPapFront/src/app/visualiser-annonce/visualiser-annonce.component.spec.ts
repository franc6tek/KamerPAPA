import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VisualiserAnnonceComponent } from './visualiser-annonce.component';

describe('VisualiserAnnonceComponent', () => {
  let component: VisualiserAnnonceComponent;
  let fixture: ComponentFixture<VisualiserAnnonceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VisualiserAnnonceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VisualiserAnnonceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
