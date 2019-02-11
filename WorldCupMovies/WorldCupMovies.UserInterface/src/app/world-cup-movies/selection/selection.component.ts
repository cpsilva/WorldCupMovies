import { WorldCupMoviesService } from './../world-cup-movies.service';
import { HttpService } from './../../shared/services/http.service';
import { Filme } from './../../models/filme.model';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Resultado } from 'src/app/models/resultado.model';

@Component({ selector: 'app-world-cup-movies-selection', templateUrl: './selection.component.html' })
export class WorldCupMoviesSelectionComponent implements OnInit {
  filmes: Filme[] = new Array<Filme>();
  quantidadeTotalSelecionar = 8;

  constructor(
    private readonly httpService: HttpService,
    private readonly worldCupMoviesService: WorldCupMoviesService,
    private readonly router: Router) { }

  ngOnInit(): void {
    this.listarFilmes();
  }

  listarFilmes() {
    this.httpService.getMovies<Array<Filme>>().subscribe(filmes => {
      return this.filmes = filmes;
    });
  }

  isQuantidadeSelecionada() {
    return this.quantidadeSelecionada() === this.quantidadeTotalSelecionar;
}

  listarFilmesSelecionados() {
    return this.filmes.filter((filme) => filme.selecionado);
  }

  quantidadeSelecionada(): number {
    return this.listarFilmesSelecionados().length;
  }

  gerarCampeonato() {
    this.httpService.post<Resultado>('Campeonato', this.listarFilmesSelecionados()).subscribe((result) => {
      this.worldCupMoviesService.setResutadoCampeonato(result);
      this.router.navigate(['copa-filmes/resultado']);
    });
  }
}
