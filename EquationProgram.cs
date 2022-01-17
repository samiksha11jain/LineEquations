using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineEquation
{
    public class EquationProgram
    {
        public double x1, x2, y1, y2;
        public double userIP()
        {
            Console.WriteLine("enter x1 and x2 value");
            x1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y1 and y2 value");
            y1 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            return Lengths();
        }
        public double Lengths()
        {
            double temp1 = Math.Pow((x2 - x1), 2);
            double temp2 = Math.Pow((y1 - y2), 2);
            double result = Math.Sqrt(temp1 + temp2);
            return result;
        }
    }
}
