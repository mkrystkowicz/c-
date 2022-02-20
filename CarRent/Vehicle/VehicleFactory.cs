using System;
namespace CarRent
{
    public class VehicleFactory
    {
        public VehicleFactory()
        {
        }

        public Vehicle CreateVehicle(VehicleType vehicleType)
        {
            switch(vehicleType)
            {
                case VehicleType.LIMO:
                    return new Limousine();
                case VehicleType.SPORT:
                    return new SportsCar();
                case VehicleType.SUV:
                    return new Suv();
                default:
                    return null;
            }
        }
    }
}
