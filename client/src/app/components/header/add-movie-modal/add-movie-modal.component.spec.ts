import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddMovieModalComponent } from './add-movie-modal.component';

describe('AddMovieModalComponent', () => {
  let component: AddMovieModalComponent;
  let fixture: ComponentFixture<AddMovieModalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddMovieModalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddMovieModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
