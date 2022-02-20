using System;
namespace CarRent
{
    public class AddCarOption
    {
        CarRentSignleton cr;

        public AddCarOption()
        {
            cr = CarRentSignleton.GetInstance();
        }

        public void PickCarType()
        {
            Console.Clear();
            Console.WriteLine("Jaki dodajesz rodzaj samochodu");
            Console.WriteLine("0 - Powrot\n");
            Console.WriteLine("1 - Limuzyna");
            Console.WriteLine("2 - Sportowy");
            Console.WriteLine("3 - Suv");
            Console.Write("Opcja: ");
            string value = Console.ReadLine();

            if(value == "0") { return; }
            Console.Clear();
            if (value == "1" || value == "2" || value == "3")
            {
                Vehicle newVehicle = GetNewVehicle(value);
                Vehicle configuredVehicle = ConfigureNewVehicle(newVehicle);

                switch (value)
                {
                    case "1":
                        cr.addToGarage(ConfigureNewLimo(configuredVehicle));
                        break;
                    case "2":
                        cr.addToGarage(ConfigureNewSportCar(configuredVehicle));
                        break;
                    case "3":
                        cr.addToGarage(ConfigureNewSuv(configuredVehicle));
                        break;
                }
            }
            else
            {
                AddCarOption addCarOption = new AddCarOption();
                addCarOption.PickCarType();
            }
        }

        private Vehicle ConfigureNewVehicle(Vehicle vehicle)
        {
            VehicleBuilder vehicleBuilder = new VehicleBuilder(vehicle);
            VehicleIdBuilder idBuilder = new VehicleIdBuilder();

            Console.WriteLine("Marka:");
            string make = Console.ReadLine();
            Console.WriteLine("Model:");
            string model = Console.ReadLine();
            Console.WriteLine("Rocznik (Wartość liczbowa):");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Moc (hp - Wartość liczbowa):");
            int hp = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kolor:");
            string color = Console.ReadLine();
            Console.WriteLine("Przebieg (Wartość liczbowa):");
            int milage = Int32.Parse(Console.ReadLine());

            string id = idBuilder.setVehicleId(make, hp, year).build();

            return vehicleBuilder.setId(id).setMake(make).setModel(model).setYear(year).setHP(hp).setColor(color).setMilage(milage).build();
        }

        private SportsCar ConfigureNewSportCar(Vehicle vehicle)
        {
            Console.WriteLine("Czas 0-60mph (Wartość liczbowa):");
            float time = float.Parse(Console.ReadLine());
            Console.WriteLine(time);
            SportsCarBuilder builder = new SportsCarBuilder((SportsCar)vehicle);

            return builder.set0_60(time).build();
        }

        private Suv ConfigureNewSuv(Vehicle vehicle)
        {
            Console.WriteLine("Naped 4x4 (Wartość true/false):");
            bool awd = bool.Parse(Console.ReadLine());
            SuvBuilder builder = new SuvBuilder((Suv)vehicle);

            return builder.setAwd(awd).build();
        }

        private Limousine ConfigureNewLimo(Vehicle vehicle)
        {
            Console.WriteLine("Masaz (Wartość true/false):");
            bool massage = bool.Parse(Console.ReadLine());
            LimousineBuilder builder = new LimousineBuilder((Limousine)vehicle);

            return builder.setMassages(massage).build();
        }

        private Vehicle GetNewVehicle(string value)
        {
            VehicleFactory vehicleFactory = new VehicleFactory();
            VehicleType carType = (VehicleType)Enum.Parse(typeof(VehicleType), value);
            Vehicle newVehicle = vehicleFactory.CreateVehicle(carType);

            return newVehicle;
        }
    }
}
