import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListAllActorsComponent } from './list-all-actors.component';

describe('ListAllActorsComponent', () => {
  let component: ListAllActorsComponent;
  let fixture: ComponentFixture<ListAllActorsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListAllActorsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListAllActorsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
