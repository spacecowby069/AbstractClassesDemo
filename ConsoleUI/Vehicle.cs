using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2000;

        public string Make { get; set; } = "Generic Manufacturer";

        public string Model { get; set; } = "Generic Model";

        


        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I'm virtually driving my vehicle.");
        }
    }
}
