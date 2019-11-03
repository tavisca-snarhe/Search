import { Injectable } from '@angular/core';
import { Item } from '../models/Item';
import { Observable } from 'rxjs';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class SearchService {  

  searchURLBase: string = "http://localhost:53215/api/search?query=";

  constructor(private http: HttpClient) { }

  search(query: string):Observable<Item[]> {
    let searchURL = this.searchURLBase + query;

    return this.http.get<Item[]>(searchURL);
  }
}
