
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class OperationsTwoNum
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subs(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multi(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            if (num2 == 0) return 0;
            return num1/num2;
        }
        public static double Power(double num1, double num2)
        {
            return Math.Pow(num1,num2);
        }
      

    }
}
