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
       
}
