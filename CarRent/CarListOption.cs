using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent
{
    public class CarListOption
    {
        readonly CarRentSignleton cr;

        public CarListOption()
        {
            cr = CarRentSignleton.GetInstance();
        }

        public void PickListOption()
        {
            Console.Clear();
            Console.WriteLine("Wybierz filtr:");
            Console.WriteLine("0 - Powrot\n");
            Console.WriteLine("1 - Wszystkie");
            Console.WriteLine("2 - Limuzyny");
            Console.WriteLine("3 - Samochody sportowe");
            Console.WriteLine("4 - SUVy");
            Console.Write("Opcja: ");
            int option = Int32.Parse(Console.ReadLine());
            Console.Clear();

            List<Vehicle> vechicles = allVehicles();
            switch (option)
            {
                case 1:
                    printVehicles(vechicles);
                    break;
                case 2:
                    List<Limousine> limousines = getLimousines(vechicles);
                    printVehicles(limousines);
                    break;
                case 3:
                    List<SportsCar> sportCars = getSportCars(vechicles);
                    printVehicles(sportCars);
                    break;
                case 4:
                    List<Suv> suvs = getSuvs(vechicles);
                    printVehicles(suvs);
                    break;
            }

            Console.ReadLine();
        }

        private List<Suv> getSuvs(List<Vehicle> vechicles)
        {
            return vechicles.OfType<Suv>().ToList();
        }

        private List<SportsCar> getSportCars(List<Vehicle> vechicles)
        {
            return vechicles.OfType<SportsCar>().ToList();
        }

        private List<Limousine> getLimousines(List<Vehicle> vechicles)
        {
            return vechicles.OfType<Limousine>().ToList();
        }

        private List<Vehicle> allVehicles()
        {
            return cr.getGarage();
        }

        private void printVehicles<T>(List<T> vehicles) where T : IVehicle
        {
            Console.WriteLine(String.Format("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Id", "Marka", "Model", "Rocznik", "Kolor", "Stan pojazdu"));
            vehicles.ForEach(vehicle => Console.WriteLine(String.Format("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", vehicle.id, vehicle.make, vehicle.model, vehicle.year, vehicle.color, getCarState(vehicle))));
        }

        private string getCarState(IVehicle vehicle)
        {
            IVehicleState state = vehicle.getState();

            switch (state)
            {
                case Vehicle.VehicleFree vehicleFree:
                    return "Wolny";
                case Vehicle.VehicleBusy vehicleBusy:
                    return "Zajety";
                case Vehicle.VehicleBroken vehicleBroken:
                    return "W naprawie";
                default:
                    return "Brak informacji";
            }
        }
    }
}
