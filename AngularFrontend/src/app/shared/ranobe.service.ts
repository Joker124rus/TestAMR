import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Ranobe } from '../ranobes/shared/ranobe.model'

@Injectable({
  providedIn: 'root'
})
export class RanobeService {

  private ranobesUrl = '/api/ranobes';
  private adminUrl = '/api/admin';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  /**
   * Constructor.
   */
  constructor(
    private http: HttpClient
  ) { }

  /**
   * GET ranobe by id.
   * @param id Ranobe id.
   * @returns Ranobe.
   */
  getRanobeById(id: number): Observable<Ranobe>{
    const url = `${this.ranobesUrl}/${id}`;

    return this.http.get<Ranobe>(url);
  }

  /**
   * GET all ranobes.
   * @returns Ranobe array.
   */
  getRanobes(): Observable<Ranobe[]> {
    return this.http.get<Ranobe[]>(this.ranobesUrl);
  }

  /**
   * POST: Create new ranobe.
   * @param ranobe Ranobe to create.
   * @returns Request.
   */
  createRanobe(ranobe: Ranobe): Observable<Ranobe> {
    return this.http.post<Ranobe>(this.adminUrl, ranobe, this.httpOptions);
  }
}
