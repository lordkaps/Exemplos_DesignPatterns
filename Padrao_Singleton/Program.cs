using System;

namespace Padrao_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CHAMADA SINGLETON SIMPLES
            Cadeira cadeira1 = Cadeira.Instance;
            cadeira1.Quantidade = 1;

            Cadeira cadeira2 = Cadeira.Instance;
            cadeira2.Quantidade = 5;

            Console.WriteLine(cadeira1.Quantidade.ToString());
            Console.WriteLine(cadeira2.Quantidade.ToString());
            Console.ReadLine();

            // CHAMADA SINGLETON POR GENERICS
            CadeiraDeFerro cadeiraDeFerro = SingletonGenerics<CadeiraDeFerro>.Instance();
            cadeiraDeFerro.Quantidade = 5;
            cadeiraDeFerro.TipoDeFerro = "Doce";


            CadeiraDeFerro cadeiraDeFerro2 = SingletonGenerics<CadeiraDeFerro>.Instance();
            cadeiraDeFerro2.TipoDeFerro = "Temperado";

            CadeiraDeMadeira cadeiraDeMadeira = SingletonGenerics<CadeiraDeMadeira>.Instance();
            cadeiraDeMadeira.TipoMadeira = "Wood";

            Console.WriteLine(cadeiraDeFerro.Quantidade.ToString());
            Console.WriteLine(cadeiraDeMadeira.TipoMadeira);
            Console.ReadLine();
        }
    }
    }
}
