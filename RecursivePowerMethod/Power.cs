using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePowerMethod
{
    public class Power
    {
        public int Calculate(int number, int power)
        {
            if (power == 0)
                return 1;
            else
                return number * Calculate(number, power - 1);
        }
    }
}
