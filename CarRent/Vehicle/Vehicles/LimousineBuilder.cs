using System;
namespace CarRent
{
    public class LimousineBuilder
    {
        private Limousine vehicle;

        public LimousineBuilder(Limousine vehicle)
        {
            this.vehicle = vehicle;
        }

        public LimousineBuilder setMassages(bool value)
        {
            this.vehicle.massages = value;
            return this;
        }

        public Limousine build()
        {
            return this.vehicle;
        }
    }
}
