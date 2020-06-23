import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Movie } from '../models/Movie';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MoviesService {

  API_URI = 'https://localhost:44397/api'

  constructor(private http: HttpClient) { }

  getMovies(): Observable<any>{
    return this.http.get<any>('/api/Movie');
  }

  getMovie(id: number): Observable<any>{
    return this.http.get<any>(`/api/Movie/${id}`);
  }

  insertMovie(movie: Movie): Observable<any>{
    return this.http.post<any>(`${this.API_URI}/Movie`, movie);
  }

  updateMovie(id: number, updateMovie: Movie): Observable<any>{
    return this.http.put<any>(`${this.API_URI}/Movie/${id}`, updateMovie);
  }

  deleteMovie(id: number): Observable<any>{
    return this.http.delete<any>(`${this.API_URI}/Movie/${id}`);
  }
}
