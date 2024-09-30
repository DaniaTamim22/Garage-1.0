using Garage_1._0.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Garage
{
    public class Garage<T> where T : Vehicle
    {
        private readonly int capacity;
        private Vehicle[] vehicles;
        public Garage(int capacity)
        {
            this.capacity = capacity;
            vehicles = new Vehicle[capacity];
        }
    }
}
