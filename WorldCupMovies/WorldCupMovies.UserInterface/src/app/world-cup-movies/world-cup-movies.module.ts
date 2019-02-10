import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SharedModule } from '../shared/shared.module';
import { WorldCupMoviesComponent } from './world-cup-movies.component';
import { WorldCupMoviesResultComponent } from './result/result.component';
import { WorldCupMoviesSelectionComponent } from './selection/selection.component';

const routes: Routes = [
    {
        children: [
            { path: '', pathMatch: 'full', redirectTo: 'selection' },
            { path: 'result', component: WorldCupMoviesResultComponent },
            { path: 'selection', component: WorldCupMoviesSelectionComponent }
        ],
        component: WorldCupMoviesComponent,
        path: ''
    }
];

@NgModule({
    declarations: [
        WorldCupMoviesComponent,
        WorldCupMoviesResultComponent,
        WorldCupMoviesSelectionComponent
    ],
    imports: [
        RouterModule.forChild(routes),
        SharedModule
    ]
})
export class WorldCupMoviesModule { }
