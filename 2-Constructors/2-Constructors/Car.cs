using System;


namespace _2_Constructors
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("car is begin {0}", registrationNumber);
        }
    }
}
