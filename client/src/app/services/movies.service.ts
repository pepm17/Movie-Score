import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MoviesService {

  API_URI = 'http://localhost:4200/home'
  constructor() { }
}
