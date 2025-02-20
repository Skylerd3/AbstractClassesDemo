using System;
namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The Motorcycle drives on two wheels");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle Virtual Drive Method");
        }
    }
}

