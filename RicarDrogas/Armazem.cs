using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Armazem {

    Dictionary<int, int> _armazem;
    public Armazem() {
        _armazem = new Dictionary<int, int>();
    }    
    public void IncluirProdutoArmazem(Produtos prod, int qtdInicial) {
        _armazem.Add(prod.Id, qtdInicial);
    }
    public void FaturaProdutoArmazem(Produtos prod, int qtd) {
        if (VerificaArmazem(prod, qtd))
            _armazem[prod.Id] -= qtd;        
        else
            throw new Exception("Produto não existe em nossa rede.");
    }
    public bool VerificaArmazem(Produtos prod, int qtd) {

        if (_armazem[prod.Id] < qtd)
            return false;
        else
            return true;
    }
    public void ReposicaoArmazem(Produtos prod, int qtd) {

        _armazem[prod.Id] += qtd;
    }    


}

