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

  getMovie(id: number): Observable<Movie>{
    return this.http.get<Movie>(`${this.API_URI}/Movie/${id}`);
  }

  insertMovie(movie: Movie): Observable<Movie>{
    return this.http.post<Movie>(`${this.API_URI}/Movie`, movie);
  }

  updateMovie(id: number, updateMovie: Movie): Observable<boolean>{
    return this.http.put<boolean>(`${this.API_URI}/Movie/${id}`, updateMovie);
  }

  deleteMovie(id: number): Observable<boolean>{
    return this.http.delete<boolean>(`${this.API_URI}/Movie/${id}`);
  }
}
