import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RanobesComponent } from './ranobes.component';

describe('RanobesComponent', () => {
  let component: RanobesComponent;
  let fixture: ComponentFixture<RanobesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RanobesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RanobesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
