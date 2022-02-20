using System;
using System.Collections.Generic;

namespace CarRent
{
    public class CarRentSignleton
    {
        private CarRentSignleton()
        {
        }

        private List<Vehicle> garage = new List<Vehicle>();
        private static CarRentSignleton _instance;

        public static CarRentSignleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new CarRentSignleton();
            }

            return _instance;
        }

        public Vehicle getVehicle(string id)
        {
            return garage.Find(item => item.id == id);
        }

        public void addToGarage(Vehicle vehicle)
        {
            garage.Add(vehicle);
        }

        public void removeFromGarage(string id)
        {
            Vehicle vehicle = getVehicle(id);
            garage.Remove(vehicle);
        }

        public List<Vehicle> getGarage()
        {
            return garage;
        }
    }
}
