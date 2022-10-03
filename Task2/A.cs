using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class A
    {
        public A(B heir1)
        {
            Console.WriteLine($"It's A class and its accepts class descendant arguments B ");
            Console.WriteLine("B");
            Console.WriteLine($"| -- {heir1}");
        }
        public A(B heir1, B heir2)
        {
            Console.WriteLine($"It's A class and its accepts class descendant arguments B ");
            Console.WriteLine("B");
            Console.WriteLine($"| -- {heir1}");
            Console.WriteLine($"| -- {heir2}");
        }
        public A(B heir1,B heir2, B heir3)
        {
            Console.WriteLine($"It's A class and its accepts class descendant arguments B ");
            Console.WriteLine("B");
            Console.WriteLine($"| -- {heir1}");
            Console.WriteLine($"| -- {heir2}");
            Console.WriteLine($"| -- {heir3}");     
        }

    }
}
