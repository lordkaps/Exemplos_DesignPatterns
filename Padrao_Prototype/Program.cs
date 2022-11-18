using System;

namespace Padrao_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando primeira instância como produto_1

            Product produto_1 = new Product();
            produto_1.IdCategoria = 1;
            produto_1.Classificacao = "Livros";
            produto_1.Caracteristica = new Caracteristica(10, 50, "Livro numero 1");

            //Listando informações do obj instânciado
            produto_1.MostrarInfoProduto();

            //Criando a segunda instância e clonar do obj produto_1.
            Product produto_2 = (Product)produto_1.Clone();

            //Listando info do produto clone.
            produto_2.MostrarInfoProduto();

            //Modificando info do produto_1 e listando infor dos produtos.
            produto_1.IdCategoria = 2;
            produto_1.Classificacao = "Brinquedos";
            produto_1.Caracteristica = new Caracteristica(05, 100, "Pula-Pula");

            Console.WriteLine("Dados do Produto 1: ");
            produto_1.MostrarInfoProduto();
            Console.WriteLine("Dados do Produto 2: ");
            produto_2.MostrarInfoProduto();
        }
    }
}
