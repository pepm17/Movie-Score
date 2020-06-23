import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormScoreComponent } from './form-score.component';

describe('FormScoreComponent', () => {
  let component: FormScoreComponent;
  let fixture: ComponentFixture<FormScoreComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormScoreComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormScoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
