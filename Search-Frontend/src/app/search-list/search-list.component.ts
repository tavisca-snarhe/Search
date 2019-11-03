import { Component, OnInit } from '@angular/core';
import { Item } from '../models/Item';
import { SearchService } from '../services/google-search.service';

@Component({
  selector: 'app-search-list',
  templateUrl: './search-list.component.html',
  styleUrls: ['./search-list.component.scss']
})

export class SearchListComponent implements OnInit {

  items: Item[] = [
    {
      heading: "Strong heading",
      link: "www.google.com",
      text: "ajsfjkshdjfhjads j adsdfhskjad ddsh kjadgjk agjkd jkg"
    },
    {
      heading: "Strong heading 2",
      link: "www.google.com",
      text: "ajsfjkshdjfhjads j adsdfhskjad ddsh kjadgjk agjkd jkg"
    }
  ]

  constructor(private _googlSearchService: SearchService) { }

  ngOnInit() {
    this.items = [];
  }

  onSearch(query: string) {
    this._googlSearchService.search(query).subscribe(results => this.items = results);
  }
}
