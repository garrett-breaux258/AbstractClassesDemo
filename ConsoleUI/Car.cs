using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Vehicle is driving");
        }

        public bool HasTrunk { get; set; } = true;
       
        
    }
}
