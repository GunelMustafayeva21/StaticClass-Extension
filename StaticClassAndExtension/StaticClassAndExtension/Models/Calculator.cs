using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndExtension.Models
{
    static  class Calculator
    {
        public static int Sum(int number1, int number2)
        {
            return number1 +number2;
        }
        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
