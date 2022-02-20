using System;
namespace CarRent
{
    public interface IVehicleState
    {
        void onRent(Vehicle vehicle);
        void onReturn(Vehicle vehicle);
        void onBroke(Vehicle vehicle);
        void onRepair(Vehicle vehicle);
    }
}
