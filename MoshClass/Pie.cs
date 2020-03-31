using System;

namespace MoshClass
{
    public class Pie
    {
        public double EstimatePie(long number)
        {
            double numberPointCircle = 0;
            double numberPointTotal = 0;
            long i = 0;
            do
            {
                double x = new Random().NextDouble();
                double y = new Random().NextDouble();
                //double distance = Math.Pow(x, 2) + Math.Pow(y, 2);
                static double square(double number) => number * number;
                double distance = square(x) + square(y);

                if (distance <= 1)
                    numberPointCircle += 1;

                numberPointTotal += 1;


                i++;
            } while (i <= number);

            return 4 * (numberPointCircle / numberPointTotal);
        }
    }
}
