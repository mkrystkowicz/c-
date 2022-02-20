using System;
namespace CarRent
{
    abstract public partial class Vehicle : IVehicle
    {
        private IVehicleState _state = new VehicleFree();
        public string id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public int horsePower { get; set; }
        public string color { get; set; }
        public int milage { get; set; }

        public Vehicle()
        {
        }

        public void setState(IVehicleState state) => _state = state;

        public IVehicleState getState()
        {
            return this._state;
        }
    }
}
