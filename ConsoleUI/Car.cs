using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
            NumberOfWindows = 0;
        }

        public int NumberOfTires { get; set; }

        public int NumberOfWindows { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"Im' driving a {GetType().Name} in an abstract method, it is a {GetType().BaseType.Name}");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("I'm virtually driving my vehicle.");
        }
    }
}
