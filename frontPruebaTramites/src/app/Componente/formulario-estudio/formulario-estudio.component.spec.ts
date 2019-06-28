import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormularioEstudioComponent } from './formulario-estudio.component';

describe('FormularioEstudioComponent', () => {
  let component: FormularioEstudioComponent;
  let fixture: ComponentFixture<FormularioEstudioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormularioEstudioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormularioEstudioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
