using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree1 = new BinarySearchTree();

            # region data entry
            tree1.insert(5);
            tree1.insert(10);
            tree1.insert(12);
            tree1.insert(15);
            tree1.insert(20);
            tree1.insert(30);
            tree1.insert(1);
            tree1.insert(17);
            tree1.insert(130);
            tree1.insert(60);
            #endregion data entry 
            
            Console.WriteLine(tree1.smallest());
            Console.WriteLine(tree1.largest());
            //Pizza myPizza = new Pizza { diameter = 1.5 };
            //Console.WriteLine(myPizza.findArea());
            //Console.WriteLine(177.Add(7));
            ////prints 84

            //Console.WriteLine((0.5).Square());
            ////prints 0.25
            //Console.ReadKey();
            //
        }
    }
}
