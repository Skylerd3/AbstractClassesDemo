using System;
namespace ConsoleUI
{
	internal class Car : Vehicle
	{
		public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The Car drives on four wheels");

        }

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default Virtual Drive Method");
        }





    }
}

