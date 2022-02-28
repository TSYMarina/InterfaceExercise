using System;
using System.Collections.Generic;
using System.Text;


//In your IVehicle

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: All vehicles have a number of wheels... for now..
 */

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfPassengers { get; set; }
        public bool IsDrivable { get; set; }
        public string Make { get; set; }
    }
    

}
