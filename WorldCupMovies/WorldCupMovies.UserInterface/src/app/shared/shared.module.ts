import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ServicesModule } from './services/services.module';

@NgModule({
    exports: [
        CommonModule,
        FormsModule,
        HttpClientModule,
        ReactiveFormsModule,
        ServicesModule
    ],
    imports: [
        CommonModule,
        FormsModule,
        HttpClientModule,
        ReactiveFormsModule
    ]
})
export class SharedModule { }
