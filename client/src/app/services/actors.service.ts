import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Actor } from '../models/Actor'
@Injectable({
  providedIn: 'root'
})
export class ActorsService {

  constructor(private http: HttpClient) { }

  getActors(): Observable<any>{
    return this.http.get<any>('/api/Actor');
  }

  getActor(id: number): Observable<any>{
    return this.http.get<any>(`/api/Actor/${id}`);
  }

  insertActor(Actor: Actor): Observable<any>{
    return this.http.post<any>(`/api/Actor`, Actor);
  }

  updateActor(id: number, updateActor: Actor): Observable<any>{
    return this.http.put<any>(`/api/Actor/${id}`, updateActor);
  }

  deleteActor(id: number): Observable<any>{
    return this.http.delete<any>(`/api/Actor/${id}`);
  }
}
