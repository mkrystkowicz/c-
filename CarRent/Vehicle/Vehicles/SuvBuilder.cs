using System;
namespace CarRent
{
    public class SuvBuilder
    {
        private Suv vehicle;

        public SuvBuilder(Suv vehicle)
        {
            this.vehicle = vehicle;
        }

        public SuvBuilder setAwd(bool value)
        {
            this.vehicle.awd = value;
            return this;
        }

        public Suv build()
        {
            return (Suv)this.vehicle;
        }
    }
}
