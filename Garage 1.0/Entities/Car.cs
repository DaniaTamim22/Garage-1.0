using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    public class Car : Vehicle
    {
        // private enum FuelType { Bensin,Diesel,Electric};
        private string fuelType;
        public string FuelType { get => fuelType; set => fuelType = value; }
        public Car(string regNum, string color, int numOfWheel, string fuelType) : base(regNum, color, numOfWheel)
        {
            FuelType = fuelType;
        }

    }
}
