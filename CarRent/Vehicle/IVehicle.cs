using System;
namespace CarRent
{
    public interface IVehicle
    {
        string id { get; set; }
        string make { get; set; }
        string model { get; set; }
        int year { get; set; }
        int horsePower { get; set; }
        string color { get; set; }
        int milage { get; set; }
        IVehicleState getState();
    }
}
