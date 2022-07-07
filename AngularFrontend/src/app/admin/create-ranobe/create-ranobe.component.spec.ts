import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateRanobeComponent } from './create-ranobe.component';

describe('CreateRanobeComponent', () => {
  let component: CreateRanobeComponent;
  let fixture: ComponentFixture<CreateRanobeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateRanobeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateRanobeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
