using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Starting the motorcycle...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the motorcycle...");
        }
    }
}