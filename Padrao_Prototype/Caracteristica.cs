namespace Padrao_Prototype
{
    public   class Caracteristica
    {
        public int Fabricante { get; set; }
        public int Preco { get; set; }
        public string Descricao { get; set; }

        public Caracteristica(int fabricante, int preco, string descricao)
        {
            Fabricante = fabricante;
            Preco = preco;
            Descricao = descricao;
        }
    }
}
