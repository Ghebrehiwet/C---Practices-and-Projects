using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Enter the number of terms of your choice: " );
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numerator of your choice: ");
            double a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the denominator of your choice: ");
            double a1 = double.Parse(Console.ReadLine());
            double x =  CalcGeoSum(a1, a2, n);
                
            Console.WriteLine(x);
            Console.ReadLine();

        }

            static double CalcGeoSum(double a1, double a2, int n)
            {
               double k, sum = 0;
               k = a2 / a1;

               if (k <= 1)
                   sum = 0;
               //else if (a1 == 0)
               //    Console.WriteLine("Please write a number other than 0");
               else
                   sum = (a1 * (Math.Pow(k, n) - 1)) / (k - 1);

               return sum; 
            }

         
    }
}
