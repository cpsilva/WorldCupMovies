import { Routes } from '@angular/router';
import { LayoutComponent } from './shared/layout/layout.component';

export const routes: Routes = [
    {
        children: [
            { path: '', pathMatch: 'full', redirectTo: 'copa-filmes' },
            { path: 'copa-filmes', loadChildren: './world-cup-movies/world-cup-movies.module#WorldCupMoviesModule' }
        ],
        component: LayoutComponent,
        path: ''
    },

    { path: '**', redirectTo: '' }
];
