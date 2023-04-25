using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Maths
    {
        public long Add(int x, int y)// incorrect answer
        {
            long result = (long)x + (long)y;
            return result;
        }
        public int Divide(int a, int b)// 3/2 incorrect answer,   DivideByZero Error
        {
            return a / b;
        }
    }
}
