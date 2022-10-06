using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ApplicationLicense
{
    internal class Application : IWorkable
    {
        private readonly int _code;
        public Application(int code)
        {
            this._code = code;
        }

        private ApplicationLicense applicationLicense = new ApplicationLicense();
        public void DoWork(int a,int b)
        {
            if(_code > 0)
            {
                if (_code % 3 == 0)
                {
                    applicationLicense.AllowPro();
                    Console.WriteLine(a+b);
                    applicationLicense.AllowPro();
                    Console.WriteLine(a*b);
                    applicationLicense.AllowPro();
                    Console.WriteLine(a - b);
                    applicationLicense.AllowPro();
                    Console.WriteLine(a / b);
                    applicationLicense.AllowPro();
                }
                if (_code % 3 == 1)
                {
                    applicationLicense.AllowTrial();
                    Console.WriteLine(a + b);
                    applicationLicense.AllowTrial();
                    Console.WriteLine(a * b);
                    applicationLicense.AllowTrial();
                    Console.WriteLine(a - b);
                    applicationLicense.AllowTrial();
                    Console.WriteLine(a / b);
                    applicationLicense.AllowTrial();
                }
                else if(_code % 3 == 2)
                {
                    applicationLicense.AllowCommon();
                    Console.WriteLine(a + b);
                    applicationLicense.AllowCommon();
                    Console.WriteLine(a - b);
                    applicationLicense.AllowCommon();
                }
            }
        }
    }
}
