using System;

namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine($"In the Car derviced class-{registrationNumber}");
        }
    }
}