using System;

namespace Padrao_Prototype
{
    public class Product : ICloneable
    {
        public int IdCategoria { get; set; }
        public string Classificacao { get; set; }
        public Caracteristica Caracteristica { get; set; }
        public object Clone()
        {
            Product copiaDoProduto = (Product)this.MemberwiseClone();
            copiaDoProduto.Caracteristica = new Caracteristica(Caracteristica.Fabricante, Caracteristica.Preco, Caracteristica.Descricao);

            return copiaDoProduto;
        }

        public void MostrarInfoProduto()
        {
            Console.WriteLine("");
            Console.WriteLine("Categoria: {0}",this.IdCategoria);
            Console.WriteLine("Classificação: {0}", this.Classificacao);
            Console.WriteLine("Caracteristicas: {0}, {1}, {2}", this.Caracteristica.Fabricante,
                                                                this.Caracteristica.Preco,
                                                                this.Caracteristica.Descricao);
            Console.ReadLine();
        }
    }
}
