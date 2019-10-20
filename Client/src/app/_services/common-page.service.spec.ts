/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { CommonPageService } from './common-page.service';

describe('Service: CommonPage', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CommonPageService]
    });
  });

  it('should ...', inject([CommonPageService], (service: CommonPageService) => {
    expect(service).toBeTruthy();
  }));
});
