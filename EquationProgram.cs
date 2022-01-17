using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineEquation
{
    public class EquationProgram
    {
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
