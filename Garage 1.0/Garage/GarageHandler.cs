using Garage_1._0.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Garage_1._0.Garage
{
    public class GarageHandler : Garage<Vehicle>, IHandler
    {
        private Garage<Vehicle> garage;
        public Garage<Vehicle> Garage { get => garage; set => garage = value; }

        public GarageHandler(string name, int capacity) : base(name, capacity)
        {
            Garage = new Garage<Vehicle>(name, capacity);
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            return Garage.AddVehicle(vehicle);
        }

        public bool LeaveGarage(Vehicle vehicle)
        {
            return Garage.RemoveVehicle(vehicle);
        }

        public Vehicle SearchVehicleByRegNum(string regNum)
        {
            return Garage.FindVehicleByRegNum(regNum);
        }

        public IEnumerable<Vehicle> SearchVehicleByColor(string color)
        {
            return Garage.FindVehicleByColor(color);
        }

        public IEnumerable<Vehicle> SearchVehicleByNumOfWheels(int numOfWheels)
        {
            return Garage.FindVehicleByNumOfWheels(numOfWheels);
        }

        public Vehicle[] GetAllVehicles()
        {
            return Garage.getAll();
        }
        public void InitializeGarage()
        {
            //create vehicles 
            //create garage

        }

        public void SeedData(GarageHandler garageHandler)
        {
            Vehicle car1 = new Vehicle("UGG123", "Red", 4);
            Vehicle car2 = new Vehicle("OFG298", "Red", 4);
            Vehicle car3 = new Vehicle("REG456", "Blue", 4);
            Vehicle car4 = new Vehicle("KLE873", "Blue", 4);
            Vehicle car5 = new Vehicle("DDL456", "Blue", 4);
            Vehicle car6 = new Vehicle("NMB343", "Red", 4);
            garageHandler.ParkVehicle(car1);
            garageHandler.ParkVehicle(car2);
            garageHandler.ParkVehicle(car3);
            garageHandler.ParkVehicle(car4);
            garageHandler.ParkVehicle(car5);
            garageHandler.ParkVehicle(car1);
        }
    }
}