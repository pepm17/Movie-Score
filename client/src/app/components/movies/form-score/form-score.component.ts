import { Component, OnInit, Input } from '@angular/core';
import { Movie } from 'src/app/models/Movie';
import { MoviesService } from '../../../services/movies.service';

@Component({
  selector: 'app-form-score',
  templateUrl: './form-score.component.html',
  styleUrls: ['./form-score.component.css']
})
export class FormScoreComponent implements OnInit {

  @Input() childMessage: Movie;
  id: number
  score: number
  constructor(private movieService: MoviesService) { }

  ngOnInit(): void {
    this.id = this.childMessage.id;
  }

  vote(){
    delete this.childMessage.id;
    delete this.childMessage.date;
    this.childMessage.score = +this.score;
    console.log(this.childMessage);
    this.movieService.updateMovie(this.id, this.childMessage).subscribe(
      res => {
        console.log(res)
      },
      err => console.log(err)
    )
  }
}
