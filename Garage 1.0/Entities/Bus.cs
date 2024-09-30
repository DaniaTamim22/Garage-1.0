using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    public class Bus : Vehicle
    {
        private int numOfSeates;
        public int NumOfSeates { get => numOfSeates; set => numOfSeates = value; }
        public Bus(string regNum, string color, int numOfWheel, int numOfSeates) : base(regNum, color, numOfWheel)
        {
            NumOfSeates = numOfSeates;
        }

    }
}
