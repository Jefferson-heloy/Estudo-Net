import { Http,Response } from "@angular/http";
import { Produto } from "../src/app/Modelos/produto"
import { Injectable } from "@angular/core";
import 'rxjs/add/operator/map';
import { Observable } from "rxjs/Observable";
import { Pedido, ItemPedido } from "../src/app/Modelos/Pedidos"

@Injectable()
export class DataServices{

  constructor(private http: Http) {

  }
  public produtos: Produto[];
  public pedido:Pedido = new Pedido();

  carregarProdutos(): Observable<Produto[]> {
    return this.http.get("/api/produtos")
      .map((result: Response) => this.produtos = result.json());
  }
  adicionarProduto(produto: Produto) {
    let itemSelecionado = this.pedido.ItensPedidos.find(i => i.Produto.id == produto.id);
    if (itemSelecionado) {
      itemSelecionado.Quantidade++;
    } else {
    let item: ItemPedido;
    item = new ItemPedido();

    item.Produto.id = produto.id;
    item.Produto.nome = produto.nome;
    item.Produto.descricao = produto.descricao;
      item.Produto.preco = produto.preco;
      item.Quantidade = 1;

      this.pedido.ItensPedidos.push(item);
    }
  }
}
