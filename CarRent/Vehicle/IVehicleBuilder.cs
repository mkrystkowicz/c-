using System;
namespace CarRent
{
    public interface IVehicleBuilder
    {
        VehicleBuilder setId(string id);
        VehicleBuilder setMake(string make);
        VehicleBuilder setModel(string model);
        VehicleBuilder setYear(int year);
        VehicleBuilder setColor(string color);
        VehicleBuilder setHP(int hp);
        VehicleBuilder setMilage(int mialge);
    }
}
