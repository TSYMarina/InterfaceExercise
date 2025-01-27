﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool isConvertible = false;
        public int trunkSpace = 0;

        public int NumberOfWheels { get; set; }
        public int NumberOfPassengers { get; set; }
        public bool IsDrivable { get; set; }
        public string Make { get; set; }
        public string Logo { get; set; }
        public int YearCreated { get; set; }

        public void PrintCarInfo()
        {
            Console.WriteLine("\n************************\n");
            Console.WriteLine("Make: " + Make + "\nNumber of Wheels: " + NumberOfWheels + "\nPassenger Capacity: " + NumberOfPassengers + "\nCurrently Drivable? " + IsDrivable + "\nCompany Logo: " + Logo + "\nConvertible: " + isConvertible + "\nTrunk Space (cubic meters): " + trunkSpace + "\n");
        }
    }



}
