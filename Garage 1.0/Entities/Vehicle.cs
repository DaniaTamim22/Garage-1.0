using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    public class Vehicle : IVehicle
    {
        private string regNum;
        private string color;
        private int numOfWheel;
        public string RegNum { get => regNum; set => regNum = value.ToUpper(); }
        public string Color { get => color; set => color = value.ToUpper(); }
        public int NumOfWheel { get => numOfWheel; set => numOfWheel = value; }

        public Vehicle(string regNum, string color, int numOfWheel)
        {
            RegNum = regNum;
            Color = color;
            NumOfWheel = numOfWheel;
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Vehicle with a registration number {RegNum} has a {color} color and {numOfWheel} wheels.\n";
        }
    }
}
