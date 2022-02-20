using System;
namespace CarRent
{
    public class VehicleBuilder : IVehicleBuilder
    {
        private Vehicle vehicle;

        public VehicleBuilder(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public VehicleBuilder setId(string id)
        {
            this.vehicle.id = id;
            return this;
        }

        public VehicleBuilder setMake(string make)
        {
            this.vehicle.make = make;
            return this;
        }

        public VehicleBuilder setModel(string model)
        {
            this.vehicle.model = model;
            return this;
        }

        public VehicleBuilder setYear(int year)
        {
            this.vehicle.year = year;
            return this;
        }

        public VehicleBuilder setColor(string color)
        {
            this.vehicle.color = color;
            return this;
        }

        public VehicleBuilder setHP(int hp)
        {
            this.vehicle.horsePower = hp;
            return this;
        }

        public VehicleBuilder setMilage(int milage)
        {
            this.vehicle.milage = milage;
            return this;
        }

        public Vehicle build()
        {
            return this.vehicle;
        }
    }
}
