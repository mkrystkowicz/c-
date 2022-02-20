using System;
namespace CarRent
{
    public class GaragePopulator
    {
        CarRentSignleton cr;
        public GaragePopulator()
        {
            this.cr = CarRentSignleton.GetInstance();

            Limousine sClass = createLimoMBS();
            Limousine eClass = createLimoMBE();
            SportsCar F458 = createSportFerrari458Italia();
            Suv X5 = createSuvBMWX5();
            Suv Q5 = createSuvAudiQ5();

            populateGarate(sClass);
            populateGarate(eClass);
            populateGarate(F458);
            populateGarate(X5);
            populateGarate(Q5);
        }

        public Limousine createLimoMBS()
        {
            VehicleFactory vehicleFactory = new VehicleFactory();
            Vehicle newVehicle = vehicleFactory.CreateVehicle(VehicleType.LIMO);
            VehicleBuilder vehicleBuilder = new VehicleBuilder(newVehicle);

            Vehicle baseVehicle = vehicleBuilder.setId("Mercedes-Benz3222018").setMake("Mercedes-Benz").setModel("S Class").setYear(2018).setHP(322).setColor("Czarny").setMilage(14739).build();
            LimousineBuilder limousineBuilder = new LimousineBuilder((Limousine)baseVehicle);
            return limousineBuilder.setMassages(true).build();
        }
        public Limousine createLimoMBE()
        {
            VehicleFactory vehicleFactory = new VehicleFactory();
            Vehicle newVehicle = vehicleFactory.CreateVehicle(VehicleType.LIMO);
            VehicleBuilder vehicleBuilder = new VehicleBuilder(newVehicle);

            Vehicle baseVehicle = vehicleBuilder.setId("Mercedes-Benz3222018").setMake("Mercedes-Benz").setModel("E Class").setYear(2015).setHP(245).setColor("Biały").setMilage(36480).build();
            LimousineBuilder typeBuilder = new LimousineBuilder((Limousine)baseVehicle);
            return typeBuilder.setMassages(false).build();
        }
        public SportsCar createSportFerrari458Italia()
        {
            VehicleFactory vehicleFactory = new VehicleFactory();
            Vehicle newVehicle = vehicleFactory.CreateVehicle(VehicleType.SPORT);
            VehicleBuilder vehicleBuilder = new VehicleBuilder(newVehicle);

            Vehicle baseVehicle = vehicleBuilder.setId("Ferrari4342011").setMake("Ferrari").setModel("458 Italia").setYear(2011).setHP(434).setColor("Czerwony").setMilage(7489).build();
            SportsCarBuilder typeBuilder = new SportsCarBuilder((SportsCar)baseVehicle);
            return typeBuilder.set0_60(3.8f).build();
        }
        public Suv createSuvBMWX5()
        {
            VehicleFactory vehicleFactory = new VehicleFactory();
            Vehicle newVehicle = vehicleFactory.CreateVehicle(VehicleType.SUV);
            VehicleBuilder vehicleBuilder = new VehicleBuilder(newVehicle);

            Vehicle baseVehicle = vehicleBuilder.setId("BMW2452017").setMake("BMW").setModel("X5").setYear(2017).setHP(245).setColor("Biały").setMilage(44234).build();
            SuvBuilder typeBuilder = new SuvBuilder((Suv)baseVehicle);
            return typeBuilder.setAwd(true).build();
        }
        public Suv createSuvAudiQ5()
        {
            VehicleFactory vehicleFactory = new VehicleFactory();
            Vehicle newVehicle = vehicleFactory.CreateVehicle(VehicleType.SUV);
            VehicleBuilder vehicleBuilder = new VehicleBuilder(newVehicle);

            Vehicle baseVehicle = vehicleBuilder.setId("Audi2522019").setMake("Audi").setModel("Q5").setYear(2019).setHP(252).setColor("Szary").setMilage(78367).build();
            SuvBuilder typeBuilder = new SuvBuilder((Suv)baseVehicle);
            return typeBuilder.setAwd(true).build();
        }

        public void populateGarate(Vehicle vehicle)
        {
            cr.addToGarage(vehicle);
        }
    }
}
