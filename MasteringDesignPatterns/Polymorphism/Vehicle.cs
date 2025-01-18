using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Vehicle
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }


        // We need virtaul keyword to allow the method to be overriden in the derived classes

        public virtual void Start()
        {
            Console.WriteLine("Starting the vehicle...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stopping the vehicle...");
        }
    }
}