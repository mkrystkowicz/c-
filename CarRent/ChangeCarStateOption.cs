using System;

namespace CarRent
{
    public class ChangeCarStateOption
    {
        CarRentSignleton cr;
        public ChangeCarStateOption()
        {
            cr = CarRentSignleton.GetInstance();
        }

        public string getCarIDMessage()
        {
            Console.Clear();
            Console.WriteLine("Podaj id samochodu");
            Console.Write("ID: ");
            return Console.ReadLine();
        }

        public void pickCarState(Vehicle vehicle)
        {
            Console.Clear();
            Console.WriteLine("Wybierz akcje:");
            Console.WriteLine("1 - Wypożycz samochod");
            Console.WriteLine("2 - Zdaj samochod");
            Console.WriteLine("3 - Samochod został rozbity");
            Console.WriteLine("4 - Samochod został naprawiony");

            string state = Console.ReadLine();
            IVehicleState prevState;

            switch (state)
            {
                case "1":
                    prevState = vehicle.getState();
                    prevState.onRent(vehicle);
                    break;
                case "2":
                    prevState = vehicle.getState();
                    prevState.onReturn(vehicle);
                    break;
                case "3":
                    prevState = vehicle.getState();
                    prevState.onBroke(vehicle);
                    break;
                case "4":
                    prevState = vehicle.getState();
                    prevState.onRepair(vehicle);
                    break;
                case "0":
                    return;
            }
        }
    }
}
