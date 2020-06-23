import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WelcomeComponent } from './components/welcome/welcome.component';
import { FindMovieComponent } from './components/movies/find-movie/find-movie.component';
import { ListMoviesComponent } from './components/movies/list-movies/list-movies.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'home'
  },
  {
    path: 'home',
    component: WelcomeComponent,
    children: [
      {
        path: '',
        component: ListMoviesComponent,
      },
      {
        path: ':id',
        component: FindMovieComponent,
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
