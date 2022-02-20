using System;
namespace CarRent
{
    public class VehicleIdBuilder
    {
        private string id;

        public VehicleIdBuilder()
        {
        }

        public VehicleIdBuilder setVehicleId(string make, int hp, int year)
        {
            this.id = make + hp.ToString() + year.ToString();
            return this;
        }

        public string build()
        {
            return id;
        }
    }
}
