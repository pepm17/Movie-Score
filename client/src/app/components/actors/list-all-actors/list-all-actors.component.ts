import { Component, OnInit } from '@angular/core';
import { ActorsService } from '../../../services/actors.service';
@Component({
  selector: 'app-list-all-actors',
  templateUrl: './list-all-actors.component.html',
  styleUrls: ['./list-all-actors.component.css']
})
export class ListAllActorsComponent implements OnInit {

  actors: any = [];
  data: any = [];
  constructor(private actorService: ActorsService) { }

  ngOnInit(): void {
    this.listActors();
  }

  listActors(){
    this.actorService.getActors().subscribe(
      res => {
        this.data = res;
        this.actors = this.data.data;
      },
      err => console.log(err)
    );
  }

}
