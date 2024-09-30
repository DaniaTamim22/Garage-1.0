using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    public class Motorcycle : Vehicle
    {
        private int cylinder;
        public int Cylinder { get => cylinder; set => cylinder = value; }
        public Motorcycle(string regNum, string color, int numOfWheel, int cylinder) : base(regNum, color, numOfWheel)
        {
            Cylinder = cylinder;
        }

    }
}
