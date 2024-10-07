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
        private string garageName;
        private Garage<Vehicle> garageVehicleArray;

        public string GarageName { get => garageName; set => garageName = value; }
        public Garage<Vehicle> GarageVehicleArray { get => garageVehicleArray; set => garageVehicleArray = value; }

        public GarageHandler(string name, int capacity, Garage<Vehicle> vehicles) : base(capacity)
        {
            GarageName = name;
            GarageVehicleArray = vehicles;
        }
        public GarageHandler(int capacity) : base(capacity)
        {

        }

        public Vehicle FindVehicle(Vehicle vehicle)
        {
            Vehicle foundVehicle = null;
            if (vehicle == null || GarageVehicleArray == null)
            {
            }
            else
            {
                foundVehicle = garageVehicleArray.FirstOrDefault(vehicle);
            }

            return foundVehicle;

        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            bool status = false;
            if (vehicle == null || GarageVehicleArray.Contains(vehicle))
            {
                status = false;
            }
            else
            {
                garageVehicleArray.Append(vehicle);
                status = true;
            }
            return status;
        }

        public void InitializeGarage()
        {
            //create vehicles 
            //create garage

        }
    }
}