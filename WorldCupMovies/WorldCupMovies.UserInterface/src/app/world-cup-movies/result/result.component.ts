import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component(
  {
    selector: 'app-world-cup-movies-result',
    templateUrl: './result.component.html'
  }
)
export class WorldCupMoviesResultComponent implements OnInit {

  constructor(
    private readonly router: Router) { }

  ngOnInit(): void {

  }

  back() {
    this.router.navigate(['world-cup-movies/selection']);
  }
}
