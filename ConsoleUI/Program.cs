using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle-DONE
             * The vehicle class shall have three string properties Year, Make, and Model-DONE
             * Set the defaults to something generic in the Vehicle class-DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation-DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.-DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle-DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles-DONE
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax-DONE
             */

            Vehicle car1 = new Car() { Year = 2016, Make = "BMW", Model = "328i", NumberOfTires = 4, NumberOfWindows = 4 };
            Car car2 = new Car() { Year = 1999, Make = "Dodge", Model = "Charger", NumberOfTires = 4, NumberOfWindows = 2 };
            Motorcycle motor1 = new Motorcycle() { Year = 2019, Make = "HarleyDavidson", Model = "Sportster" };
            Vehicle motor2 = new Motorcycle();

            /*
             * Add the 4 vehicles to the list*/
            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motor1);
            vehicles.Add(motor2);

            /* Using a foreach loop iterate over each of the properties
            */

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}");
                Console.WriteLine();

                // Call each of the drive methods for one car and one motorcycle
                car1.DriveAbstract();
                Console.WriteLine();
                car1.DriveVirtual();
                Console.WriteLine();
                motor1.DriveAbstract();
                motor2.DriveVirtual();
                #endregion
                Console.ReadLine();
            }
        }
    }
}
