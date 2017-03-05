using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class OperationOneNum
    {
        private static int max_sys = 36;
        private static String sys = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static double Strong(double num)
        {
            long s = 1;
            for (int i = 1; i <= num; ++i)
                s *= i;
            return (double)s;
        }

        public static String Convert(int num, int my_sys)
        {
            String result = "";
            if (num == 0)
                return "0";
            if ((my_sys > max_sys) || my_sys < 2)
                return null;

            while (num > 0)
            {
                result = sys[num % my_sys] + result; // reszta z dzielenia - jeśli równa 0 wypisuje pierwszy element stringa (działa jak tablica)
                num /= my_sys;
            }

            return result;
        }
       

        public static double Neg(double num)
        {
            return -num;
        }

        public static uint Fib(uint n)
        {
            {
                if (n <= 2)
                {
                    if (n == 0) return 0;
                    else return 1;
                }
                else
                {
                    uint a = 1;
                    uint b = 1;
                    uint w = 0;
                    for (int i = 0; i < n - 2; i++)
                    {
                        w = a + b;
                        a = b;
                        b = w;
                    }
                    return w;
                }
            }
        }

    }
}
