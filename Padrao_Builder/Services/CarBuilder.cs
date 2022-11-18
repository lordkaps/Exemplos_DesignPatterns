using Padrao_Builder.Models;

namespace Padrao_Builder.Services
{
    /// <summary>
    /// Concret Builder - Tipo Carro.
    /// </summary>
    public class CarBuilder : BuildVehicle
    {
        public override void BuildChassis()
        {
            vehicle = new Vehicle("Carro");
            vehicle["chassi"] = "Chassi de carro";
        }

        public override void BuildDoors()
        {
            vehicle["portas"] = "4";
        }

        public override void BuildEngine()
        {
            vehicle["motor"] = "RTX 1.0";
        }

        public override void BuildWheels()
        {
            vehicle["rodas"] = "4";
        }
    }
}
