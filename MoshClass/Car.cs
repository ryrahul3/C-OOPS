using System;

namespace MoshClass
{
    public class Car : Vehcile
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initilized.{0}",registrationNumber);
        }
    }
}
