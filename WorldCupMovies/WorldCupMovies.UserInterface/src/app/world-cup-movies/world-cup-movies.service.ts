import { Injectable } from '@angular/core';
import { Resultado } from '../models/resultado.model';

@Injectable({ providedIn: 'root' })
export class WorldCupMoviesService {
    private resultadoCampeonato: Resultado;

    setResutadoCampeonato(resultadoCampeonato: Resultado) {
        this.resultadoCampeonato = resultadoCampeonato;
    }

    getResutadoCampeonato() {
        return this.resultadoCampeonato;
    }
}
