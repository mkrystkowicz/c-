using System;

namespace CarRent
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            new GaragePopulator();
            CarRentSignleton cr = CarRentSignleton.GetInstance();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Wybierz akcję do wykonania");
                Console.WriteLine("0 - Powrot\n");
                Console.WriteLine("1 - Dodaj nowy samochód");
                Console.WriteLine("2 - Pokaż listę samochodów");
                Console.WriteLine("3 - Zmień status samochodu");
                Console.WriteLine("4 - Usuń samochod");

                Console.Write("Opcja: ");
                string option = Console.ReadLine();
                Console.WriteLine(option);

                switch (option)
                {
                    case "1":
                        AddCarOption addCarView = new AddCarOption();
                        addCarView.PickCarType();
                        break;
                    case "2":
                        CarListOption carListView = new CarListOption();
                        carListView.PickListOption();
                        break;
                    case "3":
                        ChangeCarStateOption carStateOption = new ChangeCarStateOption();
                        string id = carStateOption.getCarIDMessage();
                        Vehicle vehicle = cr.getVehicle(id);
                        carStateOption.pickCarState(vehicle);
                        break;
                    case "4":
                        DeleteCarOption deleteCarView = new DeleteCarOption();
                        deleteCarView.getCarIDMessage();
                        break;
                    case "0":
                        Console.Clear();
                        return;
                }
            }
        }
    }
}
