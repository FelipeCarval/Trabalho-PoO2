using System;


class Program {
    static void Main(string[] args) {
        Cliente Ricardo = new(1, "Ricardo", "VV");
        Cliente Davi = new(2, "Davi", "Vix");
        Cliente Saulinho = new(3, "Saulinho ÇangueBão", "NY");

        Funcionarios Maria = new(007, "Maria");
        Funcionarios Cleiton = new(008, "Cleiton");
        Funcionarios Joana = new(009, "Joana");


        Produtos ibuprofeno = new (1, "Ibuprofeno", 5.00m);
        Produtos dipirona = new(2, "Dipirona", 10.00m);
        Produtos codeina = new(3, "Codeina", 15.99m);
        Produtos remedio = new(4, "Remedio", 16.99m);
        Produtos remediobom = new(5, "Remediobom", 17.99m);
        Produtos remedioruim = new(6, "Remedioruim", 18.99m);
        Produtos cafeina = new(7, "Cafeina", 19.99m);


        Estoque estoque = new();
        estoque.IncluirProduto(ibuprofeno, 23);
        estoque.IncluirProduto(dipirona, 0);
        estoque.IncluirProduto(codeina, 10);
        estoque.IncluirProduto(cafeina, 15);

        Armazem armazem = new();
        armazem.IncluirProdutoArmazem(dipirona, 250);
        armazem.IncluirProdutoArmazem(remediobom, 250);
        armazem.IncluirProdutoArmazem(remedioruim, 0);
        armazem.IncluirProdutoArmazem(cafeina, 0);
        
        Vendas venda01 = new(1, Maria, Ricardo);
        venda01.EfetuarVenda(dipirona);

        /*Vendas venda02 = new(2, Joana, Saulinho);
        venda02.EfetuarVenda(cafeina);*/

        IStock stock = new Entregas();
        

        stock.Entregar(venda01, estoque, armazem);
        
        

    }
}


