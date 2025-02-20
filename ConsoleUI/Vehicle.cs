using System;
using System.Collections.Concurrent;
using System.Text;

namespace ConsoleUI
{
	internal abstract class Vehicle
	{
		public string Year { get; set; } = "Defult Value";
        public string Make { get; set; } = "Defult Value";
        public string Model { get; set; } = "Defult Value";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default Virtual Drive Method");
        }
    }
}

