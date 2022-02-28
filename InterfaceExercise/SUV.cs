using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int cargoSize = 0;
        public bool hasTowKit = true;

        public int NumberOfWheels { get; set; }
        public int NumberOfPassangers { get; set; }
        public bool IsDrivable { get; set; }
        public string Make { get; set; }
        public string Logo { get; set; }
        public int YearCreated { get; set; }
        public int NumberOfPassengers { get; set; }

        public void PrintSuvInfo()
        {
            Console.WriteLine("\n************************\n");
            Console.WriteLine("Make: " + Make + "\nNumber of Wheels: " + NumberOfWheels + "\nPassenger Capacity: " + NumberOfPassengers + "\nTow kit Available: " + hasTowKit + "\nCurrently Drivable? " + IsDrivable + "\nCompany Logo: " + Logo + "\nCargo Space (cubic meters): " + cargoSize + "\n");
        }
    }
}
