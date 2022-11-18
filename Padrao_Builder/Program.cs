using Padrao_Builder.Controllers;
using Padrao_Builder.Services;
using System;

namespace Padrao_Builder
{
    /// <summary>
    /// Separa a construção de um objeto complexo da sua representação de forma que o mesmo processo
    /// de construção possa criar representações diferentes.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria a montadora com os construtores de veículos.
            Assembler montadora = new Assembler();
            //Cria o construtor da moto.
            BuildVehicle moto = new MotorcycleBuilder();
            //Cria o construtor do carro.
            BuildVehicle carro = new CarBuilder();

            //Constroi e monta os veículos
            montadora.Build(carro);
            montadora.Build(moto);

            //Mostrar veículos construidos. 
            Console.WriteLine(carro.Vehicle.ToString());
            Console.ReadLine();
            Console.WriteLine(moto.Vehicle.ToString());
            Console.ReadLine();
        }
    }
}
