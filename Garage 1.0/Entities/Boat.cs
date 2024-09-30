using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    public class Boat : Vehicle
    {
        private int boatLength;
        public int BoatLength { get => boatLength; set => boatLength = value; }
        public Boat(string regNum, string color, int numOfWheel, int boatLength) : base(regNum, color, numOfWheel)
        {
            BoatLength = boatLength;
        }

    }
}
