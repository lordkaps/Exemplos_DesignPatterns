using System.Collections;

namespace Padrao_Builder
{
    /// <summary>
    /// Modelo do produto
    /// </summary>
    public class Vehicle
    {
        //Tipo do veículo
        private string type;
        //Propriedade para armazenar as partes do veículo atribuindo uma chave. Sendo possivel realizar buscas nos elementos da coleção.
        private Hashtable parts = new Hashtable();

        public Vehicle(string type)
        {
            this.type = type;
        }
        //Indexador da classe
        public object this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public override string ToString()
        {
            return $@"Tipo do veículo : {type}
                      Chassi : {parts["chassi"]}
                      Motor : {parts["motor"]}
                      Rodas : {parts["rodas"]}
                      Portas : {parts["portas"]}";
        }
    }
}
