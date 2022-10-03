using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal abstract class B
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual void MyName(string name)
        {
            _name = name;
            Console.WriteLine(name);
        }

        public virtual int Sum(int a, int b)
        {
            return a + b;
        }

        public abstract double Math(int a, int b);
    }
}
