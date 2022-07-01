using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Delegate_
{
    class Class1
    {
        public delegate double MathDelegate(double value1, double value2);

        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        public static double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }
        public static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }
        public static double Divide(double value1, double value2)
        {
            return value1 / value2;
        }
       
    }
}
