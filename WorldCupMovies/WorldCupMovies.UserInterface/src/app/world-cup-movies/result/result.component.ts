import { WorldCupMoviesService } from './../world-cup-movies.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Resultado } from 'src/app/models/resultado.model';

@Component(
  {
    selector: 'app-world-cup-movies-result',
    templateUrl: './result.component.html'
  }
)
export class WorldCupMoviesResultComponent implements OnInit {
  resultadoCampeonato: Resultado;

  constructor(
    private readonly worldCupMoviesService: WorldCupMoviesService,
    private readonly router: Router) { }

  ngOnInit(): void {
    this.resultadoCampeonato = this.worldCupMoviesService.getResutadoCampeonato();

    if (!this.resultadoCampeonato) {
      this.voltar();
    }
  }

  voltar() {
    this.router.navigate(['world-cup-movies/selection']);
  }
}
