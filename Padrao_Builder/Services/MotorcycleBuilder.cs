using Padrao_Builder.Models;

namespace Padrao_Builder.Services
{
    /// <summary>
    /// Concret Builder - Tipo Moto.
    /// </summary>
    public class MotorcycleBuilder : BuildVehicle
    {
        public override void BuildChassis()
        {
            vehicle = new Vehicle("Moto");
            vehicle["chassi"] = "Chassi de moto";
        }

        public override void BuildDoors()
        {
            vehicle["portas"] = "0";
        }

        public override void BuildEngine()
        {
            vehicle["motor"] = "XLS 250cc";
        }

        public override void BuildWheels()
        {
            vehicle["rodas"] = "2";
        }
    }
}
