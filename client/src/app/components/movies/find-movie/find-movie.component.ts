import { Component, OnInit } from '@angular/core';
import { MoviesService } from '../../../services/movies.service';
import { Movie } from 'src/app/models/Movie';
import { ActivatedRoute } from '@angular/router'
@Component({
  selector: 'app-find-movie',
  templateUrl: './find-movie.component.html',
  styleUrls: ['./find-movie.component.css']
})
export class FindMovieComponent implements OnInit {

  movie: Movie;
  data: any = [];
  score: number;

  constructor(private movieService: MoviesService, private activedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.findMovie();
    
  }

  findMovie(){
    const params = this.activedRoute.snapshot.params;
    console.log(params.id);
    this.movieService.getMovie(params.id).subscribe(
      res=>{
        this.data = res;
        this.movie = this.data.data;
        this.score = this.movie.score;
      }
    )
  }

}
