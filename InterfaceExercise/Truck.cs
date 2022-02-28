using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int bedSize = 0;
        public int numberOfAxels = 0;


        public int NumberOfWheels { get; set; }
        public int NumberOfPassengers { get; set; }
        public bool IsDrivable { get; set; }
        public string Make { get; set; }
        public string Logo { get; set; }
        public int YearCreated { get; set; }

        public void PrintTruckInfo()
        {
            Console.WriteLine("\n************************\n");
            Console.WriteLine("Make: " + Make + "\nNumber of Wheels: " + NumberOfWheels + "\nPassenger Capacity: " + NumberOfPassengers + "\nAxels: " + numberOfAxels + "\nCurrently Drivable? " + IsDrivable + "\nCompany Logo: " + Logo + "\nBed Space (feet): " + bedSize + "\n");
        }
    }
}
