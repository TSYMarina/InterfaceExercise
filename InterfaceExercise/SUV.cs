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
        public int YearsInBusiness { get; set; }
    }
}
