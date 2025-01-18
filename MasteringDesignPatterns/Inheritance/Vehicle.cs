using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehicle
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Starting the vehicle...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the vehicle...");
        }
    }
}