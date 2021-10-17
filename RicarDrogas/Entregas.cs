using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Entregas : IStock {
    public void Entregar(Vendas venda, Estoque estoque, Armazem armazem) {
        try {
            FaturaProduto(venda, estoque, armazem);           
        }
        catch (ArgumentNullException an) {
            //
        }
        catch (Exception e) {
            TratamentoDeErroDeEstoque();
        }
    }      

    private static void TratamentoDeErroDeEstoque() {
        Console.WriteLine("Venda não pode ser Faturada por falta de produto.");       
    }

    void FaturaProduto(Vendas venda, Estoque estoque, Armazem armazem) {
        try {
            foreach (var item in venda.GetProdutos()) {
                estoque.FaturaProduto(item, 1);
            }
            Console.WriteLine("\nVenda realizada com sucesso.");
        }
        catch {
            try {
                foreach (var item in venda.GetProdutos()) {
                    armazem.FaturaProdutoArmazem(item, 1);
                }
                Console.WriteLine("\nVenda realizada com sucesso.");
            }
            catch {
                Console.WriteLine("Venda não pode ser Faturada por falta de produto.");
            }
        }
    }
}

