import { Component, OnInit } from '@angular/core';
import { Movie } from 'src/app/models/Movie';
import { MoviesService } from '../../../services/movies.service'

@Component({
  selector: 'app-add-movie-modal',
  templateUrl: './add-movie-modal.component.html',
  styleUrls: ['./add-movie-modal.component.css']
})
export class AddMovieModalComponent implements OnInit {

  movie: Movie = {
    id: 0,
    title: '',
    description: '',
    score: 0,
    image: ''
  };
  constructor(private movieService: MoviesService) { }

  ngOnInit(): void {
  }

  insertMovie(){

    this.movieService.insertMovie(this.movie).subscribe(
      res => {
        console.log(res);
        window.location.reload();
      },
      err => console.log(err)
    )

  }

  onKey(event: any) { // without type info
    console.log(this.movie)
    this.movie.image += event.target.value;
  }

}
