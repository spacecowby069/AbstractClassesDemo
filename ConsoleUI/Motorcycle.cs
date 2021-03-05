using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            NumberOfTires = 2;
        }

        public int NumberOfTires { get; set; }

        public int NumberOfWindows { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} which is a {GetType().BaseType.Name} in an abstract method.");
            Console.WriteLine();
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("I'm virtually driving my motorcycle.");
        }
    }
}
