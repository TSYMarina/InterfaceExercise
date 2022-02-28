using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done - Create 2 Interfaces called IVehicle & ICompany

            //Done - Create 3 classes called Car , Truck , & SUV

            //In your IVehicle - DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany - DONE

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes - DONE

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values - DONE;
            //Creatively display and organize their values - Complete

            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.NumberOfWheels = 4;
            car1.NumberOfPassengers = 5;
            car1.IsDrivable = true;
            car1.isConvertible = false;
            car1.Logo = "Toyota Logo";
            car1.trunkSpace = 25;
            car1.PrintCarInfo();

            Car car2 = new Car();
            car2.Make = "Subaru";
            car2.NumberOfWheels = 4;
            car2.NumberOfPassengers = 5;
            car2.IsDrivable = true;
            car2.isConvertible = false;
            car2.Logo = "Subaru Logo";
            car2.trunkSpace = 21;
            car2.PrintCarInfo();

            Car car3 = new Car();
            car3.Make = "Lexus";
            car3.NumberOfWheels = 4;
            car3.NumberOfPassengers = 5;
            car3.IsDrivable = true;
            car3.isConvertible = false;
            car3.Logo = "Lexus Logo";
            car3.trunkSpace = 18;
            car3.PrintCarInfo();

            Truck truck1 = new Truck();
            truck1.Make = "Ford";
            truck1.NumberOfWheels = 4;
            truck1.bedSize = 7;
            truck1.IsDrivable = true;
            truck1.NumberOfPassengers = 4;
            truck1.numberOfAxels = 2;
            truck1.Logo = "Ford Logo";
            truck1.PrintTruckInfo();

            Truck truck2 = new Truck();
            truck2.Make = "Dodge";
            truck2.NumberOfWheels = 4;
            truck2.bedSize = 6;
            truck2.IsDrivable = true;
            truck2.NumberOfPassengers = 4;
            truck2.numberOfAxels = 2;
            truck2.Logo = "Dodge Logo";
            truck2.PrintTruckInfo();

            Truck truck3 = new Truck();
            truck3.Make = "Chevy";
            truck3.NumberOfWheels = 4;
            truck3.bedSize = 5;
            truck3.IsDrivable = false;
            truck3.NumberOfPassengers = 4;
            truck3.numberOfAxels = 2;
            truck3.Logo = "Chevrolet Logo";
            truck3.PrintTruckInfo();

            SUV suv1 = new SUV();
            suv1.Make = "Honda";
            suv1.NumberOfWheels = 4;
            suv1.NumberOfPassangers=4;
            suv1.Logo = "Honda Logo";
            suv1.cargoSize = 150;
            suv1.IsDrivable = true;
            suv1.hasTowKit = false;
            suv1.PrintSuvInfo();

            SUV suv2 = new SUV();
            suv2.Make = "BMW";
            suv2.NumberOfWheels = 4;
            suv2.NumberOfPassangers = 6;
            suv2.Logo = "BMW Logo";
            suv2.cargoSize = 150;
            suv2.IsDrivable = true;
            suv2.hasTowKit = false;
            suv2.PrintSuvInfo();

            SUV suv3 = new SUV();
            suv3.Make = "Tesla";
            suv3.NumberOfWheels = 4;
            suv3.NumberOfPassangers = 4;
            suv3.Logo = "Tesla Logo";
            suv3.cargoSize = 150;
            suv3.IsDrivable = true;
            suv3.hasTowKit = false;
            suv3.PrintSuvInfo();

        }
    }
}
