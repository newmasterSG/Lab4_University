using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DebugOne
{
    internal class Task1<T>
    {
        //Use the debug class for this Task.
        //This method uses a generic type because we don't know what type of data they want to put at the very beginning.
        public void GetInDebugMethod(T first, T second)
        {
            //Output value from debug console.
            Debug.WriteLine(first);
            Debug.WriteLine(second);
            //Change the display color in the console for the first and second argument.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Type for first parameter is : {first.GetType()} and value :  ");
            Console.WriteLine(first);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"Type for second parameter is : {second.GetType()} and value :  ");
            Console.WriteLine(second);
            //Returning the standard color.
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
