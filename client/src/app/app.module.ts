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

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    ListMoviesComponent,
    WelcomeComponent,
    FindMovieComponent,
    FormScoreComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgFallimgModule.forRoot({
      default: 'https://www.publicdomainpictures.net/pictures/280000/velka/not-found-image-15383864787lu.jpg'
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
