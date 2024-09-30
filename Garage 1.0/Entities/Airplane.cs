using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    public class Airplane : Vehicle
    {
        private int numOfMotors;

        public int NumOfMotors { get { return numOfMotors; } set { numOfMotors = value; } }
        public Airplane(string regNum, string color, int numOfWheel, int numOfMotors) : base(regNum, color, numOfWheel)
        {
            NumOfMotors = numOfMotors;
        }
    }
}
