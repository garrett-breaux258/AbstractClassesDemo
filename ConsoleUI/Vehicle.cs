using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} is driving around");
        }
        
    }
}
