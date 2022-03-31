using StaticClassAndExtension.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First number raised to power of second number");
            Console.WriteLine(number1.RaiseToPower(number2));

            Console.WriteLine("Addition");
            Console.WriteLine(Calculator.Sum(number1, number2));

            Console.WriteLine("Subtraction");
            Console.WriteLine(Calculator.Subtract(number1, number2));

            Console.WriteLine("Multiplication");
            Console.WriteLine(Calculator.Multiply(number1, number2));

            Console.WriteLine("Division");
            Console.WriteLine(Calculator.Divide(number1, number2));
        }
    }
}
