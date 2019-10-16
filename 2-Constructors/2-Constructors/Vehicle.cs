using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is begin initalized {0}", registrationNumber);
        }
    }
}
