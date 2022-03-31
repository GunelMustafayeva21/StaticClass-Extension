using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndExtension.Models
{
     static class Extension
    {
        public static int result=1;
        public static int RaiseToPower(this int number1, int number2)
        {
            for (int i = 0; i < number2; i++)
            {
                result *= number1;
            }
            return result;
        }
    }
}
