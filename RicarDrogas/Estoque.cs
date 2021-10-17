using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Estoque {

    Dictionary<int, int> _estoque;
    
    public Estoque() {
        _estoque = new Dictionary<int, int>();        
    }
    public void IncluirProduto(Produtos prod, int qtdInicial) {
        _estoque.Add(prod.Id, qtdInicial);
    }  
    public void FaturaProduto(Produtos prod, int qtd) {
        if (VerificaProduto(prod, qtd))
            _estoque[prod.Id] -= qtd;        
        else
            throw new Exception("Quantidade em nosso estoques é insuficiente.");
    }
    public bool VerificaProduto(Produtos prod, int qtd) {

        if (_estoque[prod.Id] < qtd)
            return false;        
        else
            return true;
    }   
    public void ReposicaoEstoque(Produtos prod, int qtd) {

        _estoque[prod.Id] += qtd;
    }


}