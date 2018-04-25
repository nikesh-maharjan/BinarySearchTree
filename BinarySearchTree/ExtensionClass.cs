using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public static class ExtendInt
    {
        public class Pizza
        {
            int diameter;
        }
        public static class Extend
        {
            public static double findArea(this Pizza p)
            {
                return Math.PI * p.radius * p.radius;
            }
        }

        public static int Add(this int a, int b)
        {
            return a + b;
        }

        public static double Square(this double d)
        {
            return d + d;
        }
    }

   

}
