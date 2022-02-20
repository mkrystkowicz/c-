using System;
namespace CarRent
{
    public partial class Vehicle
    {
        public class VehicleFree : IVehicleState
        {
            public void onRent(Vehicle vehicle)
            {
                vehicle.setState(new VehicleBusy());
                Console.WriteLine("Wypożyczono samochod");
                Console.ReadLine();
            }
            public void onReturn(Vehicle vehicle){}
            public void onBroke(Vehicle vehicle){}
            public void onRepair(Vehicle vehicle) { }
        }

        public class VehicleBusy : IVehicleState
        {
            public void onRent(Vehicle vehicle) {
                Console.WriteLine("Nie można wypożyczyć tego samochodu");
                Console.ReadLine();
            }
            public void onReturn(Vehicle vehicle)
            {
                vehicle.setState(new VehicleFree());
                Console.WriteLine("Oddano samochod");
                Console.ReadLine();
            }
            public void onBroke(Vehicle vehicle)
            {
                vehicle.setState(new VehicleBroken());
                Console.WriteLine("Rozbito samochod");
                Console.ReadLine();
            }
            public void onRepair(Vehicle vehicle) { }
        }

        public class VehicleBroken : IVehicleState
        {
            public void onRent(Vehicle vehicle)
            {
                Console.WriteLine("Nie można wypożyczyć tego samochodu");
                Console.ReadLine();
            }
            public void onReturn(Vehicle vehicle) { }
            public void onBroke(Vehicle vehicle){}
            public void onRepair(Vehicle vehicle) {
                vehicle.setState(new VehicleFree());
                Console.WriteLine("Naprawiono samochod");
                Console.ReadLine();
            }
        }

        public class VehicleFixed : IVehicleState
        {
            public void onRent(Vehicle vehicle)
            {
                Console.WriteLine("Nie można wypożyczyć tego samochodu");
                Console.ReadLine();
            }
            public void onReturn(Vehicle vehicle) { }
            public void onBroke(Vehicle vehicle) { }
            public void onRepair(Vehicle vehicle) { }
        }
    }
}
