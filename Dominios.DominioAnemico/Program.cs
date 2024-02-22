using System;
using System.Globalization;

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
public class ServicoProduto
{
    public void AplicarDesconto(Produto produto, decimal percentualDesconto)
    {
        decimal novoPreco = produto.Preco * (1 - percentualDesconto / 100);
        produto.Preco = novoPreco;
        string mensagem = $"Desconto aplicado ao produto {produto.Nome}: Novo preço = {novoPreco.ToString("C", new CultureInfo("pt-BR"))}";
        Console.WriteLine(mensagem);
    }
}

class Program
{
    static void Main()
    {
        //Exemplo da implementação
        Produto produto = new Produto { Nome = "Notebook", Preco = 2500.00m };
        ServicoProduto servicoProduto = new ServicoProduto();
        servicoProduto.AplicarDesconto(produto, 10);
    }
}