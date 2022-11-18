using Padrao_Builder.Services;

namespace Padrao_Builder.Controllers
{
    /// <summary>
    /// Director = Conectar as partes.
    /// A Montadora(Assembler) usa o Construir Veículo (BuildVehicle) para construir uma variedade de veículos em passos sequenciais. 
    /// </summary>
    public class Assembler
    {
        /// <summary>
        /// Metodo para construir os objetos da estrutura do veículo.
        /// </summary>
        /// <param name="buildVehicle"></param>
        public void Build(BuildVehicle buildVehicle)
        {
            buildVehicle.BuildChassis();
            buildVehicle.BuildEngine();
            buildVehicle.BuildWheels();
            buildVehicle.BuildDoors();
        }
    }
}
