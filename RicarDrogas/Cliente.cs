using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cliente {
    public Cliente(int cpf, string nome, string endereco) {
        Cpf = cpf;
        Nome = nome;
        Endereco = endereco;
    }
    public int Cpf { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
}
    
