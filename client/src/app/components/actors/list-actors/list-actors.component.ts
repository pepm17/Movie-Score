import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-list-actors',
  templateUrl: './list-actors.component.html',
  styleUrls: ['./list-actors.component.css']
})
export class ListActorsComponent implements OnInit {

  @Input() actors: any;
  constructor() { }

  ngOnInit(): void {
    console.log(this.actors);
  }

}
