using System;

namespace Quadratic_Equation_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic Equation Solver");
            Console.WriteLine("Input The Value of a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Value of b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of c:");
            int c = Convert.ToInt32(Console.ReadLine());

            string positiveValue = "The Positive Value : ";
            string negativeValue = "The Negative Value : ";
            Console.WriteLine(positiveValue+((-b + Math.Sqrt((b*b)-(4*a*c)))/(2*a)));
            Console.WriteLine(negativeValue + ((-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a)));

        }
    }
}
