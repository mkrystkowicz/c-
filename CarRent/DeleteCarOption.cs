using System;

namespace CarRent
{
    public class DeleteCarOption
    {
        CarRentSignleton cr;
        public DeleteCarOption()
        {
            cr = CarRentSignleton.GetInstance();
        }

        public void getCarIDMessage()
        {
            Console.Clear();
            Console.WriteLine("Podaj id samochodu");
            Console.Write("ID: ");
            string id = Console.ReadLine();

            cr.removeFromGarage(id);
        }
    }
}
