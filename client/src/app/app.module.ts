import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/header/navbar/navbar.component';
import { ListMoviesComponent } from './components/movies/list-movies/list-movies.component';
import { WelcomeComponent } from './components/welcome/welcome.component';
import { HttpClientModule } from '@angular/common/http';
import { NgFallimgModule } from 'ng-fallimg';
import { FindMovieComponent } from './components/movies/find-movie/find-movie.component';
import { FormScoreComponent } from './components/movies/form-score/form-score.component';
import { FormsModule } from '@angular/forms'
import { MoviesService } from './services/movies.service';
import { ListActorsComponent } from './components/actors/list-actors/list-actors.component';
import { ListAllActorsComponent } from './components/actors/list-all-actors/list-all-actors.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    ListMoviesComponent,
    WelcomeComponent,
    FindMovieComponent,
    FormScoreComponent,
    ListActorsComponent,
    ListAllActorsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    NgFallimgModule.forRoot({
      default: 'https://www.publicdomainpictures.net/pictures/280000/velka/not-found-image-15383864787lu.jpg'
    })
  ],
  providers: [MoviesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
