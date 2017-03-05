using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMoney
{
    class Money
    {
        static private double  _count;
        static private int _members;
        static public double Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = value;
            }
        }
        static public int Members
        {
            get
            {
                return _members;
            }

            set
            {
                _members = value;
            }
        }

        static public double Dim(double x)
        {
            double temp;
            temp = _members*250;
            _count = _count - temp;
            return temp;
        }

        static public double Bill(double x)
        {
            double temp1;
            if(_members < 4)
            temp1 =  500 + 50*_members;
            else
            temp1 = 700 + 50 * _members;
            _count = _count - temp1;
            return temp1;
        }
        static public double mama()
        {
            return _count;
        }

    }
}
