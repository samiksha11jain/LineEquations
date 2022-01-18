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

        public static void CompareLine(double dis1, double dis2, double dis3)
        {

            if (dis1.CompareTo(dis2) > 0)
            {
                Console.WriteLine("line one is greater than line two and three");
            }
            else if (dis1.CompareTo(dis2) > 0)
            {
                Console.WriteLine("both lines are equal");
            }
            else if (dis2.CompareTo(dis3) > 0)
            {
                Console.WriteLine("both lines are equal");
            }
            else
            {
                Console.WriteLine("line one is less than line two");
            }

            if (dis1 > dis2 && dis1 > dis3)
            {
                Console.WriteLine("line one is greater then line one and three");
            }
            else if (dis2>dis3)
            {
                Console.WriteLine("line two is greater than line three");
            }
            else
            {
                Console.WriteLine("line three is lesser thsn line two");
            }
        }
    }
      
}
