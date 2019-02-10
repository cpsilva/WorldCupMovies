import { HttpService } from './../../shared/services/http.service';
import { Movie } from './../../models/movie.model';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({ selector: 'app-world-cup-movies-selection', templateUrl: './selection.component.html' })
export class WorldCupMoviesSelectionComponent implements OnInit {
  movies: Movie[] = new Array<Movie>();
  filmsApi: string;

  constructor(
    private readonly httpService: HttpService,
    private readonly router: Router) { }

  ngOnInit(): void {
    this.listMovies();
  }

  listMovies() {
    this.httpService.getMovies<Array<Movie>>().subscribe(movies => {
      return this.movies = movies;
    });
  }
}
