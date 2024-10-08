using Garage_1._0.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
               // if (Vehicles[i].RegNum == vehicle.RegNum) return false;
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
        public IEnumerator<T> GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                yield return vehicle;
            }
        }

        public Vehicle FindVehicleByRegNum(string regNum)
        {
            if (!string.IsNullOrEmpty(regNum))
            {
                throw new ArgumentNullException(nameof(regNum));
            }

            for (int i = 0; i < Vehicles.Length; i++)
            {
                if (Vehicles[i].RegNum == regNum.ToUpper())
                    return Vehicles[i];
            }
            return null;
        }

        public IEnumerable<T> FindVehicleByColor(string color)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null && vehicle.Color == color)
                { yield return vehicle; }
            }

        }

        public IEnumerable<T> FindVehicleByNumOfWheels(int numOfWheels)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null && vehicle.NumOfWheel == numOfWheels)
                { yield return vehicle; }
            }
        }

        public Vehicle[] getAll()
        {
            //for (int i = 0;i < Vehicles.Length;i++)
            //{
            //    if (vehicles[i] != null)
            //         return vehicles[i];
            //}
            return vehicles;
        }
    }
}

