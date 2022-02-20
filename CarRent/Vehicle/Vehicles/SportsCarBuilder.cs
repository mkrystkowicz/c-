using System;
namespace CarRent
{
    public class SportsCarBuilder
    {
        private SportsCar vehicle;

        public SportsCarBuilder(SportsCar vehicle)
        {
            this.vehicle = vehicle;
        }

        public SportsCarBuilder set0_60(float value)
        {
            this.vehicle.time0_60 = value;
            return this;
        }

        public SportsCar build()
        {
            return this.vehicle;
        }
    }
}
