using System;
using System.Collections.Generic;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote()
        {
            var calculate = new RateCalcultor();
            var rating = calculate.Calculate(this);
            Console.WriteLine("");
        }


    }
}
