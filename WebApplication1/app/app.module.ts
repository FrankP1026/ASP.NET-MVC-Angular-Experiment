import { NgModule } from '@angular/core';
import { APP_BASE_HREF } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';

@NgModule({
    imports: [BrowserModule, ReactiveFormsModule, HttpModule],
    declarations: [AppComponent],
    providers: [{ provide: APP_BASE_HREF, useValue: '/shoppingcart' }],
    bootstrap: [AppComponent]
})

export class AppModule { }