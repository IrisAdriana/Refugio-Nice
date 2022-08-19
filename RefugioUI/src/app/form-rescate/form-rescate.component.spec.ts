import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormRescateComponent } from './form-rescate.component';

describe('FormRescateComponent', () => {
  let component: FormRescateComponent;
  let fixture: ComponentFixture<FormRescateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormRescateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormRescateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
