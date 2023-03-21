using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, n, R;
            n = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = n * Math.Pow(R, 2);

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));






        }
    }
}