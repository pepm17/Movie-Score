import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Movie } from '../models/Movie';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MoviesService {

  constructor(private http: HttpClient) { }

  getMovies(): Observable<any>{
    return this.http.get<any>('/api/Movie');
  }

  getMovie(id: number): Observable<any>{
    return this.http.get<any>(`/api/Movie/${id}`);
  }

  insertMovie(movie: Movie): Observable<any>{
    return this.http.post<any>(`/api/Movie`, movie);
  }

  updateMovie(id: number, updateMovie: Movie): Observable<any>{
    return this.http.put<any>(`/api/Movie/${id}`, updateMovie);
  }

  deleteMovie(id: number): Observable<any>{
    return this.http.delete<any>(`/api/Movie/${id}`);
  }
}
