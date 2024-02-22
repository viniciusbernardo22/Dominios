using System;
using System.Globalization;

// Classe de domínio rica (modelo rico)
public class Produto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }

    // Construtor
    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    // Método para aplicar desconto
    public void AplicarDesconto(decimal percentualDesconto)
    {
        if (percentualDesconto < 0 || percentualDesconto > 100)
        {
            throw new ArgumentException("Percentual de desconto inválido");
        }

        decimal novoPreco = Preco * (1 - percentualDesconto / 100);
        Preco = novoPreco;
        Console.WriteLine($"Desconto aplicado ao produto {Nome}: Novo preço = {novoPreco.ToString("C", new CultureInfo("pt-BR"))}");
    }
}

class Program
{
    static void Main()
    {
        //Exemplo da implementação
        Produto produto = new Produto("Notebook", 2500.00m);
        produto.AplicarDesconto(10);
    }
}