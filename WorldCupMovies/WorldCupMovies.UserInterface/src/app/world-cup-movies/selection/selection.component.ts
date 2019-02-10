import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({ selector: 'app-world-cup-movies-selection', templateUrl: './selection.component.html' })
export class WorldCupMoviesSelectionComponent implements OnInit {

    constructor(
        private readonly router: Router) { }

    ngOnInit(): void {

    }
}
