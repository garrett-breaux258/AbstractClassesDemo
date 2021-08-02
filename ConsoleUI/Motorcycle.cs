using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public override void DriveAbstract()
        {
            Console.WriteLine("Vehicle is driving");
        }

        public bool HasSidecar { get; set; } = true;
        
        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }

    }
}
