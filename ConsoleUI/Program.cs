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
             * Create an abstract class called Vehicle (Done)
             * The vehicle class shall have three string properties Year, Make, and Model (Done)
             * Set the defaults to something generic in the Vehicle class (Done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation (Done)
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. (Done)
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle (Done)
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle (Done_
             * Provide the implementations for the abstract methods (Done?)
             * Only in the Motorcycle class will you override the virtual drive method(Done?)
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var car = new Car()
            {
                Year = 2012,
                Make = "Hyundai",
                Model = "Genesis"
            };
            vehicles.Add(car);

            var motorcycle = new Motorcycle()
            {
                Year = 2021,
                Make = "Ducati",
                Model = "Streetfighter V4 S"
            };
            vehicles.Add(motorcycle);

            Vehicle car2 = new Car() { Year = 2000, Make = "Nissan", Model = "Altima" };
            Vehicle motorcycle2 = new Motorcycle() { Year = 2006, Make = "Yamaha", Model = "Bolt" };
            vehicles.Add(car2);
            vehicles.Add(motorcycle2);
            /*
             * Add the 4 vehicles to the list (Done)
             * Using a foreach loop iterate over each of the properties
             */
            Console.WriteLine("Today's line up of vehicles are:");
            foreach (var vehicle in vehicles)
            {
                
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }
            // Call each of the drive methods for one car and one motorcycle
            car.DriveAbstract();
            car2.DriveVirtual();
            motorcycle.DriveVirtual();
            motorcycle2.DriveAbstract();

            #endregion            
            Console.ReadLine();
        }
    }
}
