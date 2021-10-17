using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Produtos {
    public Produtos(int id, string nome, decimal valor) {
        Id = id;
        Nome = nome;
        Valor = valor;
    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }
}
    


