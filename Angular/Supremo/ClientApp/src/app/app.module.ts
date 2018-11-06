import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from "@angular/http";
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { ListaProduto } from './loja/listaProduto.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { DataServices } from "../../Services/dataServices";
import { Carrinho } from "../app/loja/carrinho/carrinho.component"
import { Loja } from "../app/loja/loja.component"
import { EfetivarCompra } from './loja/efetivarCompra/efetivarCompra.component';

let router = [
  { path: '', component: Loja },
  { path: "efetivarCompra", component: EfetivarCompra }
];
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    ListaProduto,
    Carrinho,
    CounterComponent,
    FetchDataComponent

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpModule,
    FormsModule,
    RouterModule.forRoot(router, {
      useHash: true,
      enableTracing: false
    })
  ],
  providers: [DataServices],
  bootstrap: [AppComponent]
})
export class AppModule { }
