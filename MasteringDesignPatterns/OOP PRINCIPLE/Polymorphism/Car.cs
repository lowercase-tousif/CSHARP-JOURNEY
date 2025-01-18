using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }

        public override void Start()
        {
            Console.WriteLine("Starting the car...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the car...");
        }
    }
}