import { TestBed } from '@angular/core/testing';

import { RanobeService } from './ranobe.service';

describe('RanobeService', () => {
  let service: RanobeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RanobeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
