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
        public int NumberOfPassangers { get; set; }
        public bool IsDrivable { get; set; }
        public string Make { get; set; }
        public string Logo { get; set; }
        public int YearsInBusiness { get; set; }
    }
}
