import { Component, OnInit } from '@angular/core';
import { MoviesService } from '../../../services/movies.service';
declare var $: any;

@Component({
  selector: 'app-list-movies',
  templateUrl: './list-movies.component.html',
  styleUrls: ['./list-movies.component.css'],
  providers: [MoviesService]
})
export class ListMoviesComponent implements OnInit {

  movies: any = [];
  data: any = [];

  constructor(private movieService: MoviesService) { }

  ngOnInit(): void {
    this.movieService.getMovies().subscribe(
      res => {
        this.data = res;
        this.movies = this.data.data;
      },
      err => console.log(err)
    );
  }
}
