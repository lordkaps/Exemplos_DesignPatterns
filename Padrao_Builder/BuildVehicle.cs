namespace Padrao_Builder
{
    /// <summary>
    /// Abstract Builder - Construtor abstrato.
    /// </summary>
    public abstract class BuildVehicle
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle { get { return vehicle; } }

        public abstract void BuildChassis();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
