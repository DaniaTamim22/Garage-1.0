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
        private string garageName;
        private int capacity;
        private T[] vehicles;
        public Garage(string name, int capacity)
        {
            if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
            this.capacity = capacity;
            GarageName = name;
            Vehicles = new T[capacity];
        }

        public T[] Vehicles { get => vehicles; set => vehicles = value; }
        public string GarageName { get => garageName; set => garageName = value; }

        public bool AddVehicle(T vehicle)
        {
            if (vehicle == null) throw new ArgumentNullException(nameof(vehicle));

            for (int i = 0; i < Vehicles.Length; i++)
            {
                if (Vehicles[i] == null)
                {
                    Vehicles[i] = vehicle;
                    return true;
                    // msg succ
                }
            }
            return false; // no place in garage (full)
        }

        public bool RemoveVehicle(T vehicle)
        {
            if (vehicle == null) throw new ArgumentNullException(nameof(vehicle));
            for (int i = 0; i < Vehicles.Length; i++)
            {
                if (Vehicles[i] == vehicle)
                {
                    Vehicles[i] = null;
                    return true;
                    // msg succ
                }
            }
            return false; // not found in garage 

        }

        //public bool RemoveVehicle(T vehicle)
        //{
        //    for (int i = 0; i < Vehicles.length; i++)
        //    {
        //        if (vehicles[i] == vehicle)
        //        {
        //            vehicles[i] = null;
        //            return true;
        //             msg succ
        //        }
        //    }
        //    return false; // not found in garage
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

