using Garage_1._0.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Garage
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private readonly int capacity;
        private int vehicleCountInGarage = 0;
        private Vehicle[] vehicles;
        public Garage(int capacity)
        {
            if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
            this.capacity = capacity;
            vehicles = new Vehicle[capacity];
        }

        public bool Park(Vehicle vehicle)
        {
            if (vehicle == null) throw new ArgumentNullException(nameof(vehicle));

            if (vehicleCountInGarage >= capacity)
            {
                return false;
                //add msg to user to tell no plaace found
            }
            else
            {
                return true;
                // msg succ
                vehicles = vehicles.Append(vehicle).ToArray();
                vehicleCountInGarage++;

            }
        }


        //public bool Leave(Vehicle vehicle)
        //{
        //    if (!vehicles.Any()) yield return false;

        //    if (!vehicles.Contains(vehicle)) yield return false;
        //    else
        //    {
        //        foreach (var v in vehicles)
        //        {
        //            if (v == vehicle)
        //            {
        //                vehicleCountInGarage--;
        //                //remove from vehicles
        //                yield return true;
        //            }
        //        }
        //    }
        //}




        public IEnumerator<T> GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                yield return vehicle;
            }
        }
    }
}
