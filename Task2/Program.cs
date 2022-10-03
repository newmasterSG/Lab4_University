using System;

namespace Task2
{
    internal class Program
    {
        //I gave an abstract idea, for example, we can put some game instead of class B: Cs go, dota, or we can put.
        //For example, a banking application where there are loans
        //class A can be a map or an application
        static void Main(string[] args)
        {
            Heir1 heir1 = new Heir1();
            Heir2 heir2 = new Heir2();
            Heir3 heir3 = new Heir3();
            A a = new A(heir1, heir2, heir3);
            double y = heir1.Math(1, 3);
            Console.WriteLine(y);
        }
    }
}
