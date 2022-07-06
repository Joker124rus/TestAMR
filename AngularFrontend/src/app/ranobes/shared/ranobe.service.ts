import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Ranobe } from './ranobe.model'

@Injectable({
  providedIn: 'root'
})
export class RanobeService {

  private ranobesUrl = '/api/ranobes';

  constructor(
    private http: HttpClient
  ) { }

  getRanobeById(id: number): Observable<Ranobe>{
    const url = `${this.ranobesUrl}/${id}`;

    return this.http.get<Ranobe>(url);
  }

  getRanobes(): Observable<Ranobe[]> {
    return this.http.get<Ranobe[]>(this.ranobesUrl);
  }
}
