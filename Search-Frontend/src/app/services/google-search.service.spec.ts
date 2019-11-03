import { TestBed } from '@angular/core/testing';

import { SearchService } from './google-search.service';

describe('GoogleSearchService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SearchService = TestBed.get(SearchService);
    expect(service).toBeTruthy();
  });
});
