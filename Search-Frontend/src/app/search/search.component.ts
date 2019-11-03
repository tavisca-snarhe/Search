import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { faSearch } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit {

  faSearch = faSearch;
  searchQuery: string = ""
  @Output() search = new EventEmitter<string>();

  constructor() { }

  ngOnInit() {
  }

  onSearch(searchQuery: string) {
    console.log("com = ", searchQuery);
    this.search.emit(searchQuery);
  }
}
