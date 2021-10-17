using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Vendas {
    public int Id { get; set; }
    public Funcionarios Vendedores { get; set; }
    public Cliente Comprador { get; set; }
    List<Produtos> produtos;        

    public Vendas(int id, Funcionarios vendedores, Cliente comprador) {
        Id = id;
        Vendedores = vendedores;
        Comprador = comprador;
        produtos = new List<Produtos>();
    }
    public void EfetuarVenda(Produtos prod) {      
        produtos.Add(prod);
    }
    public void RemoverProduto(Produtos prod) {
        produtos.Remove(prod);
    }
    public List<Produtos> GetProdutos() {
        return produtos;
    }

    


}
