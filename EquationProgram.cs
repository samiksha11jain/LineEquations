using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineEquation
{
    public class EquationProgram
    { 
        public double dis1, dis2, dis3;
        public void CheckEquals()
        public double userIP()
        {
            EquationProgram ip1 = new EquationProgram();
            dis1 = ip1.userIP();

            EquationProgram ip2 = new EquationProgram();
            dis2 = ip1.userIP();

            EquationProgram ip3 = new EquationProgram();
            dis3 = ip1.userIP();
            CompareEquals(dis1, dis2, dis3);
            compareLine(dis1, dis2, dis3);     
        }
        public void CompareEquals(double dis1, double dis2, double dis3)
        {
            if (dis1.Equals(dis2))
            {
                Console.WriteLine("line one and two are equals");
            }
            else if(dis2.Equals(dis3))
            {
                Console.WriteLine("line two and three are equal");
            }
            else if(dis1.Equals(dis3))
            {
                Console.WriteLine("line one and three are equal");
            }
            else
            {
                Console.WriteLine("lines are not equal");
            }
        }
    }
       

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
